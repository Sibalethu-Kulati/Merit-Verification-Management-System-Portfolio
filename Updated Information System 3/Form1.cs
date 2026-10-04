using Final_Attempt;

namespace Updated_Information_System_3
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();

        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {


            string email = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your email and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string query = @"
    SELECT PERSON_ID, FIRST_NAME, LAST_NAME, EMAIL
    FROM PERSONS
    WHERE EMAIL = @Email
      AND PASSWORD_HASH = @Password
      AND ACCOUNT_STATUS = 'ACTIVE'";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserSession.PersonId = Convert.ToInt32(reader["PERSON_ID"]);
                            UserSession.FirstName = reader["FIRST_NAME"].ToString();
                            UserSession.LastName = reader["LAST_NAME"].ToString();
                            UserSession.Email = reader["EMAIL"].ToString();

                            this.Hide();

                            verifierRepresentative_Dashboard dashboard =
                                new verifierRepresentative_Dashboard();

                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid email or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while trying to log in:\n\n" + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void sign_in_Load(object sender, EventArgs e)
        {

        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            schoolClerk_Dashboard schoolClerkDashboard = new schoolClerk_Dashboard();
            this.Hide();
            schoolClerkDashboard.Show();
        }

        private void btnStudent_login_Click(object sender, EventArgs e)
        {
            StudentDashboard stuDAsh = new StudentDashboard();
            this.Hide();
            stuDAsh.Show();
        }
    }
}
