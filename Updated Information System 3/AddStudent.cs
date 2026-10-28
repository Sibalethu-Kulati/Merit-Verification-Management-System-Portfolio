using Final_Attempt;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            // 1. Check for empty fields
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(idNumber) ||
                cboGrade.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. First Name validation (Letters and spaces only, no symbols or numbers)
            if (!Validations.IsValidName(firstName))
            {
                MessageBox.Show("First name can only contain letters and spaces (no symbols or numbers).", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFName.Focus();
                return;
            }

            // 3. Last Name validation (Letters and spaces only, no symbols or numbers)
            if (!Validations.IsValidName(lastName))
            {
                MessageBox.Show("Last name can only contain letters and spaces (no symbols or numbers).", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLSurname.Focus();
                return;
            }

            // 4. ID Number validation (Exactly 13 digits)
            if (idNumber.Length != 13 || !idNumber.All(char.IsDigit))
            {
                MessageBox.Show("ID Number must be exactly 13 digits.", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDnumber.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // 5. Which school does this clerk belong to?
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

                    // 6. Block duplicate ID numbers
                    using (var cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM LEARNER_REGISTER WHERE SA_ID_NUMBER = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idNumber);
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("A learner with this ID number already exists.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 7. Insert the learner
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

                MessageBox.Show("Learner added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFName.Clear();
                txtLSurname.Clear();
                txtIDnumber.Clear();
                cboGrade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}