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
                            "FROM SCHOOL_APPLICATIONS";

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
                "FROM ORG_APPLICATIONS";

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

        public static bool UpdateApplicationStatus(int applicationId, bool isHighSchool, string status, int reviewerPersonId)
        {
            string tableName = isHighSchool
                ? "SCHOOL_APPLICATIONS"
                : "ORG_APPLICATIONS";

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
                ? "SCHOOL_APPLICATIONS"
                : "ORG_APPLICATIONS";

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
    }
}
