using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucItAdmin_learners : UserControl
    {
        private int selectedStudentId = -1; // Tracks the currently selected student ID from the grid

        public ucItAdmin_learners()
        {
            InitializeComponent();

            // Wire up grid row selection event (adjust dataGridView name if it differs in your designer)
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Ensure it's not a new/empty row
                if (row.Cells["First Name"].Value != null)
                {
                    // Adjust column name/index if your primary key column is named differently (e.g. "LearnerID")
                    selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);

                    string firstName = row.Cells["First Name"].Value?.ToString() ?? "";
                    string lastName = row.Cells["Last Name"].Value?.ToString() ?? "";

                    // Populate student full name field
                    txtStudentFullName.Text = $"{firstName} {lastName}";

                    // Populate contact fields if they exist in the grid
                    txtEmailAdress.Text = row.Cells["Email"]?.Value?.ToString() ?? "";
                    txtPhoneNUmber.Text = row.Cells["PhoneNumber"]?.Value?.ToString() ?? "";
                }
            }
        }

        private void btn_UpdateSendLogin_Click(object sender, EventArgs e)
        {
            // 1. Check if a row from the grid was selected
            if (selectedStudentId == -1 || string.IsNullOrWhiteSpace(txtStudentFullName.Text))
            {
                MessageBox.Show("Select from the row above to update & send login credentials to student",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Specific field-by-field empty checks
            if (Validations.IsTextBoxEmpty(txtEmailAdress, "Email Address") ||
                Validations.IsTextBoxEmpty(txtPhoneNUmber, "Phone Number"))
            {
                return;
            }

            // 3. Email format validation
            if (!Validations.IsValidEmail(txtEmailAdress.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAdress.Focus();
                return;
            }

            // 4. Phone number validation (Must start with '0' and be 10 digits)
            if (!Validations.IsValidPhoneNumber(txtPhoneNUmber.Text.Trim()))
            {
                MessageBox.Show("Phone number must start with '0' and contain 10 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNUmber.Focus();
                return;
            }

            // 5. Database Update & Email Dispatch Logic
            try
            {
                // TODO: Add your SQL UPDATE statement using selectedStudentId, txtEmailAdress.Text, and txtPhoneNUmber.Text
                // TODO: Add your EmailSender call to send credentials to the student

                MessageBox.Show("Student contact details updated and login credentials sent successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Clear fields after success
                txtStudentFullName.Clear();
                txtEmailAdress.Clear();
                txtPhoneNUmber.Clear();
                selectedStudentId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucItAdmin_learners_Load(object sender, EventArgs e)
        {
            int id = ApplicationDatabase.GetItAdminSchoolId(UserSession.PersonId);
            ApplicationDatabase.LoadLearners(dataGridView1, id) ;
        }
    }
}