using Final_Attempt;
using Microsoft.Data.SqlClient;
using System;

namespace Updated_Information_System_3
{
    internal enum UserRole
    {
        SchoolClerk,
        Principal,
        VerifierRepresentative
    }

    internal class NewUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserRole Role { get; set; }
        public int InstitutionId { get; set; }
        public int HighSchoolId { get; set; }
        public string StaffNumber { get; set; }
    }

    internal class AddUserResult
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RoleDescription { get; set; }
        public string TempPassword { get; set; }
    }

    internal static class DatabaseUsers
    {
        internal static int InsertPerson(SqlConnection conn, SqlTransaction tx, NewUser u, string passwordHash)
        {
            const string checkSql = @"SELECT COUNT(*) FROM PERSON
                                      WHERE EMAIL = @Email OR PHONE = @Phone";

            using (var check = new SqlCommand(checkSql, conn, tx))
            {
                check.Parameters.AddWithValue("@Email", u.Email);
                check.Parameters.AddWithValue("@Phone", u.Phone);

                if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    throw new ApprovalException(
                        "A user with this email address or phone number already exists.");
            }

            const string insertSql = @"INSERT INTO PERSON (FIRST_NAME, LAST_NAME, GENDER, EMAIL, PHONE, PASSWORD_HASH)
                                       OUTPUT INSERTED.PERSON_ID
                                       VALUES (@First, @Last, @Gender, @Email, @Phone, @Hash)";

            using (var cmd = new SqlCommand(insertSql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@First", u.FirstName);
                cmd.Parameters.AddWithValue("@Last", u.LastName);
                cmd.Parameters.AddWithValue("@Gender", u.Gender);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Phone", u.Phone);
                cmd.Parameters.AddWithValue("@Hash", passwordHash);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        internal static string InsertSubtype(SqlConnection conn, SqlTransaction tx, NewUser u, int personId)
        {
            string table;
            string institutionCol;
            string description;

            switch (u.Role)
            {
                case UserRole.SchoolClerk:
                    table = "SCHOOL_CLERK";
                    institutionCol = "HIGH_SCHOOL_ID";
                    description = "a School Clerk";
                    break;

                case UserRole.Principal:
                    table = "PRINCIPAL";
                    institutionCol = "HIGH_SCHOOL_ID";
                    description = "a Principal";
                    break;

                case UserRole.VerifierRepresentative:
                    table = "VERIFIER_REPRESENTATIVE";
                    institutionCol = "ORG_ID";
                    description = "a Verifier Representative";
                    break;

                default:
                    throw new ApprovalException("This role is not supported yet.");
            }

            string sql = $"INSERT INTO {table} (PERSON_ID, {institutionCol}, STAFF_NUMBER) VALUES (@P, @I, @S)";

            using (var cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.AddWithValue("@P", personId);
                cmd.Parameters.AddWithValue("@I", u.InstitutionId);
                cmd.Parameters.AddWithValue("@S", u.StaffNumber);
                cmd.ExecuteNonQuery();
            }

            return description;
        }

        internal static AddUserResult AddUser(NewUser u)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {
                        string tempPassword = PasswordClass.GenerateTemporaryPassword();
                        int personId = InsertPerson(conn, tx, u, PasswordClass.Hash(tempPassword));
                        string roleDescription = InsertSubtype(conn, tx, u, personId);

                        tx.Commit();

                        return new AddUserResult
                        {
                            PersonId = personId,
                            Name = u.FirstName + " " + u.LastName,
                            Email = u.Email,
                            RoleDescription = roleDescription,
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
        internal static (bool isSchool, int institutionId) GetInstitutionForItAdmin(int personId)
        {
            const string schoolSql = "SELECT HIGH_SCHOOL_ID FROM SCHOOL_IT_ADMIN WHERE PERSON_ID = @P";
            const string orgSql = "SELECT ORG_ID FROM ORG_IT_ADMIN WHERE PERSON_ID = @P";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (var cmd = new SqlCommand(schoolSql, conn))
                {
                    cmd.Parameters.AddWithValue("@P", personId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (true, Convert.ToInt32(result));
                }

                using (var cmd = new SqlCommand(orgSql, conn))
                {
                    cmd.Parameters.AddWithValue("@P", personId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (false, Convert.ToInt32(result));
                }
            }

            throw new ApprovalException("Only an IT admin can add staff.");
        }
    }
}