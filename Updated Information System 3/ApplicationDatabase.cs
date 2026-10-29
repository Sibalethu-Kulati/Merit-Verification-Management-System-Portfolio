using Final_Attempt;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Updated_Information_System_3
{
    internal class ApplicationDatabase
    {
        public static void RefreshHigh_SchoolGridData(DataGridView dgvRequests)
        {
            string query =
                            "SELECT APPLICATION_ID AS [Application ID], EMIS_NO AS [EMIS Number], SCHOOL_NAME AS [Organization Name], " +
                            "SCHOOL_EMAIL AS [Email Address], SCHOOL_PHONE AS [Telephone], " +
                            "STREET_NUMBER AS [Street Number], STREET_NAME AS [Street Name], SUBURB AS [Suburb], " +
                            "POSTAL_CODE AS [Postal Code], CITY_NAME AS [City], PROVINCE AS [Province], " +
                            "'High School' AS [Organization Type], " +
                            "IT_ADMIN_FIRST_NAME AS [Recipient First Name], IT_ADMIN_LAST_NAME AS [Recipient Last Name], " +
                            "IT_ADMIN_EMAIL AS [Recipient Email], 'IT Admin' AS [Recipient Role], " +
                            "APPLICATION_STATUS AS [Status] " +
                            "FROM SCHOOL_APPLICATION";

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRequests.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool AddLearnerToRegister(string saIdNumber, string firstName, string lastName,
                                 string grade, int highSchoolId, out string message)
        {
            message = "";


            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                // Stop duplicates: same SA ID already in the register
                string checkSql = "SELECT COUNT(*) FROM LEARNER_REGISTER WHERE SA_ID_NUMBER = @id";
                using (SqlCommand check = new SqlCommand(checkSql, conn))
                {
                    check.Parameters.AddWithValue("@id", saIdNumber);
                    if ((int)check.ExecuteScalar() > 0)
                    {
                        message = "A learner with this SA ID number is already in the register.";
                        return false;
                    }
                }

                string insertSql = @"INSERT INTO LEARNER_REGISTER
                             (SA_ID_NUMBER, FIRST_NAME, LAST_NAME, GRADE, HIGH_SCHOOL_ID)
                             VALUES (@id, @first, @last, @grade, @school)";
                using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", saIdNumber);
                    cmd.Parameters.AddWithValue("@first", firstName);
                    cmd.Parameters.AddWithValue("@last", lastName);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.Parameters.AddWithValue("@school", highSchoolId);
                    cmd.ExecuteNonQuery();
                }

                message = "Learner added to the register.";
                return true;
            }
        }
        public static void RefreshOrgGridData(DataGridView dgvRequests)
        {
            string query =
                "SELECT APPLICATION_ID AS [Application ID], PROVIDER_CODE AS [Provider Code], " +
                "ORG_NAME AS [Organization Name], " +
                "ORG_EMAIL AS [Email Address], " +
                "ORG_PHONE AS [Telephone], " +
                "STREET_NUMBER AS [Street Number], " +
                "STREET_NAME AS [Street Name], " +
                "SUBURB AS [Suburb], " +
                "POSTAL_CODE AS [Postal Code], " +
                "CITY_NAME AS [City], " +
                "PROVINCE AS [Province], " +
                "'Verifying Organization' AS [Organization Type], " +
                "IT_ADMIN_FIRST_NAME AS [Recipient First Name], " +
                "IT_ADMIN_LAST_NAME AS [Recipient Last Name], " +
                "IT_ADMIN_EMAIL AS [Recipient Email], " +
                "'IT Admin' AS [Recipient Role], " +
                "APPLICATION_STATUS AS [Status] " +
                "FROM ORG_APPLICATION";

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRequests.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading verifying organization requests: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void LoadHighSchools(DataGridView dgv)
        {
            string query = @"
        SELECT
            h.EMIS_NO,
            h.SCHOOL_NAME,
            h.EMAIL,
            h.PHONE,
            CONCAT(
                a.STREET_NUMBER, ' ',
                a.STREET_NAME, ', ',
                COALESCE(a.SUBURB + ', ', ''),
                c.CITY_NAME, ', ',
                c.PROVINCE, ' ',
                a.POSTAL_CODE
            ) AS FULL_ADDRESS
        FROM HIGH_SCHOOL h
        INNER JOIN ADDRESS a
            ON h.ADDRESS_ID = a.ADDRESS_ID
        INNER JOIN CITY c
            ON a.CITY_ID = c.CITY_ID";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        dgv.Rows.Clear();

                        while (reader.Read())
                        {
                            dgv.Rows.Add(
                                reader["EMIS_NO"].ToString(),
                                reader["SCHOOL_NAME"].ToString(),
                                reader["EMAIL"].ToString(),
                                reader["PHONE"].ToString(),
                                reader["FULL_ADDRESS"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load high schools:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public static bool DeleteCertificate(int certificateId, out string message)
        {
            message = "";
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                using (var cmd = new SqlCommand(
                    "DELETE FROM CERTIFICATE WHERE CERTIFICATE_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", certificateId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() == 1;
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                message = "This certificate is linked to a verification request and cannot be deleted.";
                return false;
            }
        }
        public static void LoadCertificates(DataGridView dgv)
        {
            string query = @"SELECT c.CERTIFICATE_ID, c.HOLDER_FIRST_NAME, c.HOLDER_LAST_NAME,
                        c.CERTIFICATE_NUMBER, c.TITLE,
                        t.TYPE_NAME, c.ISSUE_DATE, c.FILE_NAME
                     FROM CERTIFICATE c
                     JOIN CERTIFICATE_TYPE t ON t.CERTIFICATE_TYPE_ID = c.CERTIFICATE_TYPE_ID
                     WHERE c.HIGH_SCHOOL_ID = (SELECT HIGH_SCHOOL_ID
                                               FROM SCHOOL_CLERK
                                               WHERE PERSON_ID = @PersonId)
                     ORDER BY c.UPLOAD_DATE DESC";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var da = new SqlDataAdapter(query, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@PersonId", UserSession.PersonId);
                var dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
        }
        public static void SearchOrgGridData(DataGridView dgv, string searchBy, string searchText)
        {
            // empty box or nothing selected = show everything
            if (string.IsNullOrWhiteSpace(searchText))
            {
                RefreshOrgGridData(dgv);
                return;
            }

            string column = searchBy == "Provider Code" ? "PROVIDER_CODE" : "ORG_NAME";

            string query =
                "SELECT APPLICATION_ID AS [Application ID], PROVIDER_CODE AS [Provider Code], " +
                "ORG_NAME AS [Organization Name], ORG_EMAIL AS [Email Address], ORG_PHONE AS [Telephone], " +
                "STREET_NUMBER AS [Street Number], STREET_NAME AS [Street Name], SUBURB AS [Suburb], " +
                "POSTAL_CODE AS [Postal Code], CITY_NAME AS [City], PROVINCE AS [Province], " +
                "'Verifying Organization' AS [Organization Type], " +
                "IT_ADMIN_FIRST_NAME AS [Recipient First Name], IT_ADMIN_LAST_NAME AS [Recipient Last Name], " +
                "IT_ADMIN_EMAIL AS [Recipient Email], 'IT Admin' AS [Recipient Role], " +
                "APPLICATION_STATUS AS [Status] " +
                "FROM ORG_APPLICATION " +
                "WHERE " + column + " LIKE @search";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchText.Trim() + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        public static void SearchHighSchoolRequests(DataGridView dgv, string searchBy, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                RefreshHigh_SchoolGridData(dgv);
                return;
            }

            string column = searchBy == "EMIS Number" ? "EMIS_NO" : "SCHOOL_NAME";

            string query =
                "SELECT APPLICATION_ID AS [Application ID], EMIS_NO AS [EMIS Number], SCHOOL_NAME AS [Organization Name], " +
                "SCHOOL_EMAIL AS [Email Address], SCHOOL_PHONE AS [Telephone], " +
                "STREET_NUMBER AS [Street Number], STREET_NAME AS [Street Name], SUBURB AS [Suburb], " +
                "POSTAL_CODE AS [Postal Code], CITY_NAME AS [City], PROVINCE AS [Province], " +
                "'High School' AS [Organization Type], " +
                "IT_ADMIN_FIRST_NAME AS [Recipient First Name], IT_ADMIN_LAST_NAME AS [Recipient Last Name], " +
                "IT_ADMIN_EMAIL AS [Recipient Email], 'IT Admin' AS [Recipient Role], " +
                "APPLICATION_STATUS AS [Status] " +
                "FROM SCHOOL_APPLICATION " +
                "WHERE CAST(" + column + " AS VARCHAR(100)) LIKE @search";

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText.Trim() + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching requests: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void SearchHighSchools(DataGridView dgv, string searchBy, string searchText)
        {
            // Whitelist the column (column names can't be SQL parameters)
            string column;
            switch (searchBy)
            {
                case "EMIS Number": column = "h.EMIS_NO"; break;
                case "School Name": column = "h.SCHOOL_NAME"; break;
                default:
                    LoadHighSchools(dgv);   // nothing valid selected: show all
                    return;
            }

            string query = $@"
        SELECT
            h.EMIS_NO,
            h.SCHOOL_NAME,
            h.EMAIL,
            h.PHONE,
            CONCAT(
                a.STREET_NUMBER, ' ',
                a.STREET_NAME, ', ',
                COALESCE(a.SUBURB + ', ', ''),
                c.CITY_NAME, ', ',
                c.PROVINCE, ' ',
                a.POSTAL_CODE
            ) AS FULL_ADDRESS
        FROM HIGH_SCHOOL h
        INNER JOIN ADDRESS a ON h.ADDRESS_ID = a.ADDRESS_ID
        INNER JOIN CITY c ON a.CITY_ID = c.CITY_ID
        WHERE CAST({column} AS VARCHAR(100)) LIKE @search";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@search", "%" + searchText.Trim() + "%");
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        dgv.Rows.Clear();

                        while (reader.Read())
                        {
                            dgv.Rows.Add(
                                reader["EMIS_NO"].ToString(),
                                reader["SCHOOL_NAME"].ToString(),
                                reader["EMAIL"].ToString(),
                                reader["PHONE"].ToString(),
                                reader["FULL_ADDRESS"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search high schools:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        internal static DataTable GetInstitutions(bool isHighSchool)
        {
            string table = isHighSchool ? "HIGH_SCHOOL" : "VERIFYING_ORGANIZATION";
            string idCol = isHighSchool ? "HIGH_SCHOOL_ID" : "ORG_ID";
            string codeCol = isHighSchool ? "EMIS_NO" : "PROVIDER_CODE";
            string nameCol = isHighSchool ? "SCHOOL_NAME" : "ORG_NAME";

            string sql = $@"
                SELECT I.{idCol}   AS InstitutionId,
                       I.{codeCol} AS Code,
                       I.{nameCol} AS Name,
                       I.EMAIL     AS Email,
                       I.PHONE     AS Phone,
                       CONCAT_WS(', ',
                           A.STREET_NUMBER + ' ' + A.STREET_NAME,
                           A.SUBURB,
                           C.CITY_NAME,
                           C.PROVINCE,
                           A.POSTAL_CODE) AS Address
                FROM {table} I
                JOIN ADDRESS A ON A.ADDRESS_ID = I.ADDRESS_ID
                JOIN CITY C    ON C.CITY_ID = A.CITY_ID
                ORDER BY I.{nameCol}";

            var dt = new DataTable();

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var adapter = new SqlDataAdapter(sql, conn))
            {
                adapter.Fill(dt);
            }

            return dt;
        }

        public static bool UpdateApplicationStatus(int applicationId, bool isHighSchool, string status, int reviewerPersonId)
        {
            string tableName = isHighSchool
                ? "SCHOOL_APPLICATION"
                : "ORG_APPLICATION";

            string query =
                $"UPDATE {tableName} " +
                "SET APPLICATION_STATUS = @Status, " +
                "REVIEWED_AT = SYSDATETIME(), " +
                "REVIEWED_BY = @ReviewerPersonId " +
                "WHERE APPLICATION_ID = @ApplicationId " +
                "AND APPLICATION_STATUS = 'PENDING'";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@ReviewerPersonId", reviewerPersonId);
                cmd.Parameters.AddWithValue("@ApplicationId", applicationId);

                conn.Open();

                return cmd.ExecuteNonQuery() == 1;
            }
        }
        public static bool SaveAccessRequest(
            bool isHighSchool, string institutionId, string organizationName, string organizationEmail, string organizationPhone,
            string streetNumber, string streetName, string suburb, string city, string province, string postalCode, string adminFirstName,
            string adminLastName, string adminGender, string adminEmail, string adminPhone, string staffNumber)
        {
            string tableName = isHighSchool
                ? "SCHOOL_APPLICATION"
                : "ORG_APPLICATION";

            string institutionColumn = isHighSchool
                ? "EMIS_NO"
                : "PROVIDER_CODE";

            string organizationNameColumn = isHighSchool
                ? "SCHOOL_NAME"
                : "ORG_NAME";

            string organizationEmailColumn = isHighSchool
                ? "SCHOOL_EMAIL"
                : "ORG_EMAIL";

            string organizationPhoneColumn = isHighSchool
                ? "SCHOOL_PHONE"
                : "ORG_PHONE";

            string sql = $@"
        INSERT INTO {tableName}
        (
            {institutionColumn},
            {organizationNameColumn},
            {organizationEmailColumn},
            {organizationPhoneColumn},
            STREET_NUMBER,
            STREET_NAME,
            SUBURB,
            CITY_NAME,
            PROVINCE,
            POSTAL_CODE,
            IT_ADMIN_FIRST_NAME,
            IT_ADMIN_LAST_NAME,
            IT_ADMIN_GENDER,
            IT_ADMIN_EMAIL,
            IT_ADMIN_PHONE,
            IT_ADMIN_STAFF_NUMBER
        )
        VALUES
        (
            @InstitutionId,
            @OrganizationName,
            @OrganizationEmail,
            @OrganizationPhone,
            @StreetNumber,
            @StreetName,
            @Suburb,
            @City,
            @Province,
            @PostalCode,
            @AdminFirstName,
            @AdminLastName,
            @AdminGender,
            @AdminEmail,
            @AdminPhone,
            @StaffNumber
        );";

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@InstitutionId", institutionId.Trim());
                command.Parameters.AddWithValue("@OrganizationName", organizationName.Trim());
                command.Parameters.AddWithValue("@OrganizationEmail", organizationEmail.Trim());
                command.Parameters.AddWithValue("@OrganizationPhone", organizationPhone.Trim());
                command.Parameters.AddWithValue("@StreetNumber", streetNumber.Trim());
                command.Parameters.AddWithValue("@StreetName", streetName.Trim());
                command.Parameters.AddWithValue("@Suburb",
                    string.IsNullOrWhiteSpace(suburb) ? DBNull.Value : suburb.Trim());
                command.Parameters.AddWithValue("@City", city.Trim());
                command.Parameters.AddWithValue("@Province", province.Trim());
                command.Parameters.AddWithValue("@PostalCode", postalCode.Trim());
                command.Parameters.AddWithValue("@AdminFirstName", adminFirstName.Trim());
                command.Parameters.AddWithValue("@AdminLastName", adminLastName.Trim());
                command.Parameters.AddWithValue("@AdminGender", adminGender);
                command.Parameters.AddWithValue("@AdminEmail", adminEmail.Trim());
                command.Parameters.AddWithValue("@AdminPhone", adminPhone.Trim());
                command.Parameters.AddWithValue("@StaffNumber", staffNumber.Trim());

                connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public static int GetClerkSchoolId(int personId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT HIGH_SCHOOL_ID FROM SCHOOL_CLERK WHERE PERSON_ID = @p", conn))
            {
                cmd.Parameters.AddWithValue("@p", personId);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public static int GetItAdminSchoolId(int personId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT HIGH_SCHOOL_ID FROM SCHOOL_IT_ADMIN WHERE PERSON_ID = @p", conn))
            {
                cmd.Parameters.AddWithValue("@p", personId);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public static void LoadSchoolStaff(DataGridView grid, int highSchoolId)
        {
            string query = @"
        SELECT p.PERSON_ID, p.FIRST_NAME, p.LAST_NAME, p.GENDER, p.EMAIL, p.PHONE, 'IT Admin' AS ROLE
        FROM PERSON p JOIN SCHOOL_IT_ADMIN a ON a.PERSON_ID = p.PERSON_ID
        WHERE a.HIGH_SCHOOL_ID = @id
        UNION ALL
        SELECT p.PERSON_ID, p.FIRST_NAME, p.LAST_NAME, p.GENDER, p.EMAIL, p.PHONE, 'Principal'
        FROM PERSON p JOIN PRINCIPAL pr ON pr.PERSON_ID = p.PERSON_ID
        WHERE pr.HIGH_SCHOOL_ID = @id
        UNION ALL
        SELECT p.PERSON_ID, p.FIRST_NAME, p.LAST_NAME, p.GENDER, p.EMAIL, p.PHONE, 'School Clerk'
        FROM PERSON p JOIN SCHOOL_CLERK c ON c.PERSON_ID = p.PERSON_ID
        WHERE c.HIGH_SCHOOL_ID = @id
        ORDER BY ROLE, LAST_NAME";

            FillStaffGrid(grid, query, highSchoolId);
        }

        public static void LoadOrgStaff(DataGridView grid, int organizationId)
        {
            string query = @"
        SELECT p.PERSON_ID, p.FIRST_NAME, p.LAST_NAME, p.GENDER, p.EMAIL, p.PHONE, 'Verifier Representative' AS ROLE
        FROM PERSON p JOIN VERIFIER_REPRESENTATIVE v ON v.PERSON_ID = p.PERSON_ID
        WHERE v.ORG_ID = @id
        ORDER BY p.LAST_NAME";

            FillStaffGrid(grid, query, organizationId);
        }

        public static void LoadStaffForItAdmin(DataGridView grid, int personId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                    "SELECT HIGH_SCHOOL_ID FROM SCHOOL_IT_ADMIN WHERE PERSON_ID = @p", conn))
                {
                    cmd.Parameters.AddWithValue("@p", personId);
                    object school = cmd.ExecuteScalar();
                    if (school != null)
                    {
                        LoadSchoolStaff(grid, Convert.ToInt32(school));
                        return;
                    }
                }

                using (var cmd = new SqlCommand(
                    "SELECT ORG_ID FROM ORG_IT_ADMIN WHERE PERSON_ID = @p", conn))
                {
                    cmd.Parameters.AddWithValue("@p", personId);
                    object org = cmd.ExecuteScalar();
                    if (org != null)
                        LoadOrgStaff(grid, Convert.ToInt32(org));
                }
            }
        }

        private static void FillStaffGrid(DataGridView grid, string query, int id)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var da = new SqlDataAdapter(query, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", id);
                var dt = new DataTable();
                da.Fill(dt);
                grid.AutoGenerateColumns = true;
                grid.DataSource = dt;
            }

            grid.Columns["PERSON_ID"].Visible = false;
            grid.Columns["FIRST_NAME"].HeaderText = "First Name";
            grid.Columns["LAST_NAME"].HeaderText = "Last Name";
            grid.Columns["GENDER"].HeaderText = "Gender";
            grid.Columns["EMAIL"].HeaderText = "Email";
            grid.Columns["PHONE"].HeaderText = "Phone";
            grid.Columns["ROLE"].HeaderText = "Role";
        }

        public static void LoadLearners(DataGridView grid, int highSchoolId)
        {
            string query = @"SELECT l.REGISTER_ID, l.FIRST_NAME, l.LAST_NAME, l.GRADE, l.SA_ID_NUMBER,
                            (SELECT COUNT(*)
                             FROM CERTIFICATE c
                             WHERE c.HOLDER_ID_NUMBER = l.SA_ID_NUMBER
                               AND c.HIGH_SCHOOL_ID = l.HIGH_SCHOOL_ID) AS CERT_COUNT
                     FROM LEARNER_REGISTER l
                     WHERE l.HIGH_SCHOOL_ID = @school
                     ORDER BY l.LAST_NAME, l.FIRST_NAME";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var da = new SqlDataAdapter(query, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@school", highSchoolId);
                var dt = new DataTable();
                da.Fill(dt);
                grid.AutoGenerateColumns = true;
                grid.DataSource = dt;
            }

            grid.Columns["REGISTER_ID"].Visible = false;
            grid.Columns["FIRST_NAME"].HeaderText = "First Name";
            grid.Columns["LAST_NAME"].HeaderText = "Last Name";
            grid.Columns["Grade"].HeaderText = "Grade";
            grid.Columns["SA_ID_NUMBER"].HeaderText = "SA ID Number";
            grid.Columns["CERT_COUNT"].HeaderText = "Certificates";
        }
        
        public static void AddUser()
        {

        }
    }
}
