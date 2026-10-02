using Final_Attempt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    [ToolboxItem(true)]
    public partial class ucVerifierDashboard : UserControl
    {
        public ucVerifierDashboard()
        {
            InitializeComponent();
            
        }
        private void LoadUserName()
        {
            string query = @"
        SELECT FIRST_NAME, LAST_NAME
        FROM PERSONS
        WHERE PERSON_ID = @PersonID";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", UserSession.PersonId);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["FIRST_NAME"].ToString();
                            string lastName = reader["LAST_NAME"].ToString();

                            lblName.Text = firstName + " " + lastName;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load user information:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ucVerifierDashboard_Load(object sender, EventArgs e)
        {
            LoadUserName();
        }
    }
}
