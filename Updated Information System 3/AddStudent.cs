using Final_Attempt;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            cboGrade.Items.AddRange(new object[] { "8", "9", "10", "11", "12" });
        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            string firstName = txtFName.Text.Trim();
            string lastName = txtLSurname.Text.Trim();
            string idNumber = txtIDnumber.Text.Trim();

            if (firstName == "" || lastName == "" || cboGrade.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (idNumber.Length != 13 || !idNumber.All(char.IsDigit))
            {
                MessageBox.Show("ID Number must be exactly 13 digits.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // 1. Which school does this clerk belong to?
                    int highSchoolId;
                    using (var cmd = new SqlCommand(
                        "SELECT HIGH_SCHOOL_ID FROM SCHOOL_CLERK WHERE PERSON_ID = @pid", conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", UserSession.PersonId);
                        object result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Could not find your school.");
                            return;
                        }
                        highSchoolId = Convert.ToInt32(result);
                    }

                    // 2. Block duplicate ID numbers
                    using (var cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM LEARNER_REGISTER WHERE SA_ID_NUMBER = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idNumber);
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("A learner with this ID number already exists.");
                            return;
                        }
                    }

                    // 3. Insert the learner
                    using (var cmd = new SqlCommand(
                        @"INSERT INTO LEARNER_REGISTER
                    (SA_ID_NUMBER, FIRST_NAME, LAST_NAME, GRADE, HIGH_SCHOOL_ID)
                  VALUES (@id, @first, @last, @grade, @school)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idNumber);
                        cmd.Parameters.AddWithValue("@first", firstName);
                        cmd.Parameters.AddWithValue("@last", lastName);
                        cmd.Parameters.AddWithValue("@grade", cboGrade.Text);
                        cmd.Parameters.AddWithValue("@school", highSchoolId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Learner added successfully.");
                txtFName.Clear();
                txtLSurname.Clear();
                txtIDnumber.Clear();
                cboGrade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
