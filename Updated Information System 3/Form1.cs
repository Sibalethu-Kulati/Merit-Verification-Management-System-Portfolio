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

            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~S.Kulati~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
             * Used SQL for routing the different type of users.
             * this method checks is a user exists in the PERSON table first!
             * if true then it checks if does it exist in any of the subtypes
             * if they don't exist in the person then login is cancelled
             */
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

            string query = @"SELECT 
                            P.PERSON_ID,
                            P.FIRST_NAME,
                            P.LAST_NAME,
                            P.EMAIL,
                            P.PASSWORD_HASH,
                            CASE
                                WHEN EXISTS (
                                    SELECT 1
                                    FROM SYSTEM_ADMIN SA
                                    WHERE SA.PERSON_ID = P.PERSON_ID
                                ) THEN 'SYSTEM_ADMIN'

                                WHEN EXISTS (
                                    SELECT 1
                                    FROM LEARNER L
                                    WHERE L.PERSON_ID = P.PERSON_ID
                                ) THEN 'LEARNER'

                                WHEN EXISTS (
                                    SELECT 1
                                    FROM SCHOOL_CLERK SC
                                    WHERE SC.PERSON_ID = P.PERSON_ID
                                ) THEN 'SCHOOL_CLERK'

                                WHEN EXISTS (
                                    SELECT 1
                                    FROM PRINCIPAL PR
                                    WHERE PR.PERSON_ID = P.PERSON_ID
                                ) THEN 'PRINCIPAL'

                                WHEN EXISTS (
                                    SELECT 1
                                    FROM SCHOOL_IT_ADMIN SIA
                                    WHERE SIA.PERSON_ID = P.PERSON_ID
                                ) THEN 'SCHOOL_IT_ADMIN'

                                WHEN EXISTS (
                                    SELECT 1
                                    FROM ORG_IT_ADMIN OIA
                                    WHERE OIA.PERSON_ID = P.PERSON_ID
                                ) THEN 'ORG_IT_ADMIN'

                                WHEN EXISTS (
                                    SELECT 1
                                    FROM VERIFIER_REPRESENTATIVE VR
                                    WHERE VR.PERSON_ID = P.PERSON_ID
                                ) THEN 'VERIFIER_REPRESENTATIVE'

                                ELSE NULL
                            END AS USER_ROLE

                        FROM PERSON P

                        WHERE P.EMAIL = @Email
                        AND P.ACCOUNT_STATUS = 'ACTIVE'
                        ";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);


                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read() && PasswordClass.Verify(password, reader["PASSWORD_HASH"].ToString()))

                        {
                            UserSession.PersonId = Convert.ToInt32(reader["PERSON_ID"]);
                            UserSession.FirstName = reader["FIRST_NAME"].ToString();
                            UserSession.LastName = reader["LAST_NAME"].ToString();
                            UserSession.Email = reader["EMAIL"].ToString();
                            String userRole = reader["USER_ROLE"].ToString();
                            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~S.Kulati~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                             * the form gets hidden immediately then depending on the results the new one is opened
                             * validation/ authentication is done behind the scene when the form is hidden
                            */
                            this.Hide();

                            switch (userRole)
                            {
                                case "SCHOOL_CLERK":
                                case "PRINCIPAL":
                                    schoolClerk_Dashboard schoolClerkDashboard =
                                        new schoolClerk_Dashboard();

                                    schoolClerkDashboard.Show();
                                    break;
                                case "LEARNER":
                                    StudentDashboard studentDashboard = new StudentDashboard();
                                    studentDashboard.Show();
                                    break;

                                case "VERIFIER_REPRESENTATIVE":
                                    verifierRepresentative_Dashboard verifierDashboard =
                                        new verifierRepresentative_Dashboard();
                                    verifierDashboard.Show();
                                    break;


                                case "SYSTEM_ADMIN":
                                    systemAdmin_Dashboard systemDashboard = new systemAdmin_Dashboard();
                                    systemDashboard.Show();
                                    break;

                                case "SCHOOL_IT_ADMIN":

                                    itAdmin_Dashboard itAdminDashboard = new itAdmin_Dashboard();
                                    itAdminDashboard.Show();
                                    break;
                                case "ORG_IT_ADMIN":
                                    itAdminVerifyingOrganisation admin = new itAdminVerifyingOrganisation();
                                    admin.Show();
                                    break;
                                default:
                                    MessageBox.Show(
                                        "Your account does not have a valid application role.",
                                        "Authorization Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                                    this.Show();
                                    break;
                            }
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
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnStudent_login_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtPassword.UseSystemPasswordChar = true;
            else if (checkBox1.Checked == false)
                txtPassword.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lnkRequestAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InterfaceCreation.openRequestAccess(this);
        }

        private void btn_ITadminLogin_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
