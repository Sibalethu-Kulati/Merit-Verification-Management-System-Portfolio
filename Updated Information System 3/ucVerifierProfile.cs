using Final_Attempt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    [ToolboxItem(true)]
    public partial class ucVerifierProfile : UserControl
    {
        public ucVerifierProfile()
        {
            InitializeComponent();
            
        }
        private void LoadUserProfile()
        {
            string query = @"
        SELECT FIRST_NAME, LAST_NAME, EMAIL, PHONE, GENDER
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
                            txtFirstName.Text = reader["FIRST_NAME"].ToString();
                            txtLastName.Text = reader["LAST_NAME"].ToString();
                            txtEmail.Text = reader["EMAIL"].ToString();
                            txtPhone.Text = reader["PHONE"].ToString();
                            txtGender.Text = reader["GENDER"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load profile information:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ucVerifierProfile_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }
    }
}
