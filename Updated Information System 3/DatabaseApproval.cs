using Final_Attempt;
using Microsoft.Data.SqlClient;
using System;

namespace Updated_Information_System_3
{
    // Thrown for business-rule problems we want to show the System Admin as-is.
    internal class ApprovalException : Exception
    {
        public ApprovalException(string message) : base(message) { }
    }

    internal class ApplicationRecord
    {
        public int ApplicationId { get; set; }
        public bool IsHighSchool { get; set; }

        public string InstitutionCode { get; set; }   // EMIS_NO or PROVIDER_CODE
        public string InstitutionName { get; set; }
        public string InstitutionEmail { get; set; }
        public string InstitutionPhone { get; set; }

        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }            // may be null
        public string CityName { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminGender { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPhone { get; set; }
        public string AdminStaffNumber { get; set; }
    }

    internal static class DatabaseApproval
    {
        // Reads the application and locks the row until the transaction ends,
        // so a second Approve click waits and then sees it is no longer PENDING.
        internal static ApplicationRecord LoadPendingApplication( SqlConnection conn, SqlTransaction tx, int applicationId, bool isHighSchool)
           
        {
            string table = isHighSchool ? "SCHOOL_APPLICATION" : "ORG_APPLICATION";
            string codeCol = isHighSchool ? "EMIS_NO" : "PROVIDER_CODE";
            string nameCol = isHighSchool ? "SCHOOL_NAME" : "ORG_NAME";
            string emailCol = isHighSchool ? "SCHOOL_EMAIL" : "ORG_EMAIL";
            string phoneCol = isHighSchool ? "SCHOOL_PHONE" : "ORG_PHONE";

            string sql = $@"
                SELECT {codeCol}, {nameCol}, {emailCol}, {phoneCol},
                       STREET_NUMBER, STREET_NAME, SUBURB, CITY_NAME, PROVINCE, POSTAL_CODE,
                       IT_ADMIN_FIRST_NAME, IT_ADMIN_LAST_NAME, IT_ADMIN_GENDER,
                       IT_ADMIN_EMAIL, IT_ADMIN_PHONE, IT_ADMIN_STAFF_NUMBER,
                       APPLICATION_STATUS
                FROM {table} WITH (UPDLOCK, HOLDLOCK)
                WHERE APPLICATION_ID = @Id";

            using (var cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@Id", applicationId);

                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read())
                        throw new ApprovalException("The application could not be found.");

                    string status = r.GetString(16);
                    if (status != "PENDING")
                        throw new ApprovalException(
                            "This application has already been " + status.ToLower() + ".");

                    return new ApplicationRecord
                    {
                        ApplicationId = applicationId,
                        IsHighSchool = isHighSchool,
                        InstitutionCode = r.GetString(0).Trim(),
                        InstitutionName = r.GetString(1).Trim(),
                        InstitutionEmail = r.GetString(2).Trim(),
                        InstitutionPhone = r.GetString(3).Trim(),
                        StreetNumber = r.GetString(4).Trim(),
                        StreetName = r.GetString(5).Trim(),
                        Suburb = r.IsDBNull(6) ? null : r.GetString(6).Trim(),
                        CityName = r.GetString(7).Trim(),
                        Province = r.GetString(8).Trim(),
                        PostalCode = r.GetString(9).Trim(),
                        AdminFirstName = r.GetString(10).Trim(),
                        AdminLastName = r.GetString(11).Trim(),
                        AdminGender = r.GetString(12).Trim(),
                        AdminEmail = r.GetString(13).Trim(),
                        AdminPhone = r.GetString(14).Trim(),
                        AdminStaffNumber = r.GetString(15).Trim()
                    };
                }
            }
        }

        // Finds the city (name + province) or creates it. Returns CITY_ID.
        // Matching is case-insensitive under SQL Server's default collation.
        internal static int FindOrCreateCity(SqlConnection conn, SqlTransaction tx, string cityName, string province)
        {
            const string findSql = @"
                SELECT CITY_ID
                FROM CITY WITH (UPDLOCK, HOLDLOCK)
                WHERE CITY_NAME = @City AND PROVINCE = @Province";

            using (var find = new SqlCommand(findSql, conn, tx))
            {
                find.Parameters.AddWithValue("@City", cityName);
                find.Parameters.AddWithValue("@Province", province);

                object existing = find.ExecuteScalar();
                if (existing != null)
                    return Convert.ToInt32(existing);
            }

            const string insertSql = @"
                INSERT INTO CITY (CITY_NAME, PROVINCE)
                OUTPUT INSERTED.CITY_ID
                VALUES (@City, @Province)";

            using (var insert = new SqlCommand(insertSql, conn, tx))
            {
                insert.Parameters.AddWithValue("@City", cityName);
                insert.Parameters.AddWithValue("@Province", province);
                return Convert.ToInt32(insert.ExecuteScalar());
            }
        }
            

        internal static int InsertAddress(SqlConnection conn, SqlTransaction tx, ApplicationRecord app, int cityId)
        {
            const string sql = @"
                INSERT INTO ADDRESS (STREET_NUMBER, STREET_NAME, SUBURB, CITY_ID, POSTAL_CODE)
                OUTPUT INSERTED.ADDRESS_ID
                VALUES (@StreetNumber, @StreetName, @Suburb, @CityId, @PostalCode)";

            using (var cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@StreetNumber", app.StreetNumber);
                cmd.Parameters.AddWithValue("@StreetName", app.StreetName);
                cmd.Parameters.AddWithValue("@Suburb",
                    string.IsNullOrWhiteSpace(app.Suburb) ? DBNull.Value : (object)app.Suburb);
                cmd.Parameters.AddWithValue("@CityId", cityId);
                cmd.Parameters.AddWithValue("@PostalCode", app.PostalCode);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        internal static int InsertInstitution(SqlConnection conn, SqlTransaction tx, ApplicationRecord app, int addressId)
            
        {
            string table = app.IsHighSchool ? "HIGH_SCHOOL" : "VERIFYING_ORGANIZATION";
            string codeCol = app.IsHighSchool ? "EMIS_NO" : "PROVIDER_CODE";
            string nameCol = app.IsHighSchool ? "SCHOOL_NAME" : "ORG_NAME";
            string idCol = app.IsHighSchool ? "HIGH_SCHOOL_ID" : "ORG_ID";

            // Friendly duplicate check (the unique constraint is still the final safety net).
            string checkSql = $"SELECT COUNT(*) FROM {table} WHERE {codeCol} = @Code";
            using (var check = new SqlCommand(checkSql, conn, tx))
            {
                check.Parameters.AddWithValue("@Code", app.InstitutionCode);
                if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    throw new ApprovalException(
                        (app.IsHighSchool ? "A school with EMIS number " : "An organization with provider code ")
                        + app.InstitutionCode + " is already registered.");
            }

            string insertSql = $@"
                INSERT INTO {table} ({codeCol}, {nameCol}, EMAIL, PHONE, ADDRESS_ID)
                OUTPUT INSERTED.{idCol}
                VALUES (@Code, @Name, @Email, @Phone, @AddressId)";

            using (var cmd = new SqlCommand(insertSql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@Code", app.InstitutionCode);
                cmd.Parameters.AddWithValue("@Name", app.InstitutionName);
                cmd.Parameters.AddWithValue("@Email", app.InstitutionEmail);
                cmd.Parameters.AddWithValue("@Phone", app.InstitutionPhone);
                cmd.Parameters.AddWithValue("@AddressId", addressId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        internal static int InsertPerson(SqlConnection conn, SqlTransaction tx, ApplicationRecord app, string passwordHash)
        {
            const string checkSql = @" SELECT COUNT(*) FROM PERSON 
                                       WHERE EMAIL = @Email OR PHONE = @Phone;";
              
            using (var check = new SqlCommand(checkSql, conn, tx))
            {
                check.Parameters.AddWithValue("@Email", app.AdminEmail);
                check.Parameters.AddWithValue("@Phone", app.AdminPhone);

                if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    throw new ApprovalException(
                        "A user with this email address or phone number already exists.");
            }

            const string insertSql = @" INSERT INTO PERSON (FIRST_NAME, LAST_NAME, GENDER, EMAIL, PHONE, PASSWORD_HASH)
                                        OUTPUT INSERTED.PERSON_ID
                                        VALUES(@First, @Last, @Gender, @Email, @Phone, @Hash)";
                 
            using (var cmd = new SqlCommand(insertSql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@First", app.AdminFirstName);
                cmd.Parameters.AddWithValue("@Last", app.AdminLastName);
                cmd.Parameters.AddWithValue("@Gender", app.AdminGender);
                cmd.Parameters.AddWithValue("@Email", app.AdminEmail);
                cmd.Parameters.AddWithValue("@Phone", app.AdminPhone);
                cmd.Parameters.AddWithValue("@Hash", passwordHash);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        
        internal static void InsertItAdmin( SqlConnection conn, SqlTransaction tx, ApplicationRecord app,int personId, int institutionId)            
        {
            string sql = app.IsHighSchool
                ? "INSERT INTO SCHOOL_IT_ADMIN (PERSON_ID, HIGH_SCHOOL_ID, STAFF_NUMBER) VALUES (@P, @I, @S)"
                : "INSERT INTO ORG_IT_ADMIN (PERSON_ID, ORG_ID, STAFF_NUMBER) VALUES (@P, @I, @S)";

            using (var cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@P", personId);
                cmd.Parameters.AddWithValue("@I", institutionId);
                cmd.Parameters.AddWithValue("@S", app.AdminStaffNumber);
                cmd.ExecuteNonQuery();
            }
        }
      
        internal class ApprovalResult
        {
            public int PersonId { get; set; }
            public string AdminName { get; set; }
            public string AdminEmail { get; set; }
            public string InstitutionName { get; set; }
            public string TempPassword { get; set; }
        }
        

        internal static void MarkApproved(SqlConnection conn, SqlTransaction tx,int applicationId, bool isHighSchool, int reviewerPersonId)    
        {
            string table = isHighSchool ? "SCHOOL_APPLICATION" : "ORG_APPLICATION";

            string sql = $@"UPDATE {table}
                    SET APPLICATION_STATUS = 'APPROVED',
                    REVIEWED_AT = SYSDATETIME(),
                    REVIEWED_BY = @Reviewer
                    WHERE APPLICATION_ID = @Id
                      AND APPLICATION_STATUS = 'PENDING'";    
                    

            using (var cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@Reviewer", reviewerPersonId);
                cmd.Parameters.AddWithValue("@Id", applicationId);

                if (cmd.ExecuteNonQuery() != 1)
                    throw new ApprovalException("The application could not be approved. It may already have been reviewed.");
            }
        }
        internal static ApprovalResult ApproveApplication(int applicationId, bool isHighSchool, int reviewerPersonId)
            
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {
                        var app = LoadPendingApplication(conn, tx, applicationId, isHighSchool);
                        int cityId = FindOrCreateCity(conn, tx, app.CityName, app.Province);
                        int addressId = InsertAddress(conn, tx, app, cityId);
                        int institutionId = InsertInstitution(conn, tx, app, addressId);

                        string tempPassword = PasswordClass.GenerateTemporaryPassword();
                        int personId = InsertPerson(conn, tx, app, PasswordClass.Hash(tempPassword));

                        InsertItAdmin(conn, tx, app, personId, institutionId);
                        MarkApproved(conn, tx, applicationId, isHighSchool, reviewerPersonId);

                        tx.Commit();

                        return new ApprovalResult
                        {
                            PersonId = personId,
                            AdminName = app.AdminFirstName + " " + app.AdminLastName,
                            AdminEmail = app.AdminEmail,
                            InstitutionName = app.InstitutionName,
                            TempPassword = tempPassword
                        };
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}