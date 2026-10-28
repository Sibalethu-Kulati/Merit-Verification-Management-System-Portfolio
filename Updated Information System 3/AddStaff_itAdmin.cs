using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class AddStaff_itAdmin : Form
    {
        public AddStaff_itAdmin()
        {
            InitializeComponent();
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool isSchool;
        private int institutionId;

        private async void btn_addStaffMember_itAdmin_Click(object sender, EventArgs e)
        {
            // 1. Specific field-by-field empty checks
            if (Validations.IsTextBoxEmpty(txtName, "First Name") ||
                Validations.IsTextBoxEmpty(txtSurname, "Last Name") ||
                Validations.IsTextBoxEmpty(txtStaffNumber, "Staff Number"))
            {
                return;
            }

            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGender.Focus();
                return;
            }

            if (cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRole.Focus();
                return;
            }

            if (Validations.IsTextBoxEmpty(txtEmail, "Email Address") ||
                Validations.IsTextBoxEmpty(txtPhone, "Phone Number"))
            {
                return;
            }

            // 2. First Name validation (Letters and spaces only)
            if (!Validations.IsValidName(txtName.Text.Trim()))
            {
                MessageBox.Show("First name can only contain letters and spaces (no symbols or numbers).", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // 3. Last Name validation (Letters and spaces only)
            if (!Validations.IsValidName(txtSurname.Text.Trim()))
            {
                MessageBox.Show("Last name can only contain letters and spaces (no symbols or numbers).", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.Focus();
                return;
            }

            // 4. Email format validation
            if (!Validations.IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // 5. Phone number validation (Starts with 0 and 10 digits)
            if (!Validations.IsValidPhoneNumber(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Phone number must start with '0' and contain 10 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            UserRole role;
            switch (cboRole.SelectedItem.ToString())
            {
                case "School Clerk": role = UserRole.SchoolClerk; break;
                case "Principal": role = UserRole.Principal; break;
                default: role = UserRole.VerifierRepresentative; break;
            }

            var newUser = new NewUser
            {
                FirstName = txtName.Text.Trim(),
                LastName = txtSurname.Text.Trim(),
                Gender = cboGender.SelectedItem.ToString(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                StaffNumber = txtStaffNumber.Text.Trim(),
                Role = role,
                InstitutionId = institutionId
            };

            btn_addStaffMember_itAdmin.Enabled = false;

            try
            {
                var result = DatabaseUsers.AddUser(newUser);

                try
                {
                    await EmailSender.SendLoginDetailsAsync(
                        result.Email, result.Name, result.RoleDescription, result.TempPassword);

                    MessageBox.Show("Staff member added. Login details were emailed.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception emailEx)
                {
                    MessageBox.Show(
                        "The account was created, but the email could not be sent:\n\n" + emailEx.Message,
                        "Email Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ApprovalException ex)
            {
                MessageBox.Show(ex.Message, "Cannot Add User",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_addStaffMember_itAdmin.Enabled = true;
            }
        }

        private void AddStaff_itAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                var inst = DatabaseUsers.GetInstitutionForItAdmin(UserSession.PersonId);
                isSchool = inst.isSchool;
                institutionId = inst.institutionId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            cboGender.Items.Clear();
            cboGender.Items.AddRange(new object[] { "MALE", "FEMALE" });

            cboRole.Items.Clear();
            if (isSchool)
                cboRole.Items.AddRange(new object[] { "School Clerk", "Principal" });
            else
                cboRole.Items.Add("Verifier Representative");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CancelStaffMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}