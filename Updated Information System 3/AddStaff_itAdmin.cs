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

        private async void  btn_addStaffMember_itAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
       string.IsNullOrWhiteSpace(txtSurname.Text) ||
       string.IsNullOrWhiteSpace(txtEmail.Text) ||
       string.IsNullOrWhiteSpace(txtPhone.Text) ||
       string.IsNullOrWhiteSpace(txtStaffNumber.Text) ||
       cboGender.SelectedItem == null ||
       cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
