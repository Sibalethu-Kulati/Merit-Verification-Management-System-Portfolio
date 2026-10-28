using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucVerifyingOrgRequests : UserControl
    {
        public ucVerifyingOrgRequests()
        {
            InitializeComponent();
        }

        private void btn_viewRequest_systemAdmin_Click(object sender, EventArgs e)
        {
            {
                // 1. Check if a row is selected
                if (dgvVerifierRequests.CurrentRow == null)
                {
                    MessageBox.Show("Please select a request from the list first.",
                                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = dgvVerifierRequests.CurrentRow;
                int applicationId = Convert.ToInt32(row.Cells["Application ID"].Value);
                // 2. Extract base fields using your exact grid column names
                string provCode = row.Cells["Provider Code"]?.Value?.ToString() ?? "";
                string orgName = row.Cells["Organization Name"]?.Value?.ToString() ?? "";
                string email = row.Cells["Email Address"]?.Value?.ToString() ?? "";
                string tel = row.Cells["Telephone"]?.Value?.ToString() ?? "";
                string province = row.Cells["Province"]?.Value?.ToString() ?? "";
                string orgType = row.Cells["Organization Type"]?.Value?.ToString() ?? "";

                // 3. Extract separate address pieces and build the structured layout string
                string sNum = row.Cells["Street Number"]?.Value?.ToString() ?? "";
                string sName = row.Cells["Street Name"]?.Value?.ToString() ?? "";
                string suburb = row.Cells["Suburb"]?.Value?.ToString() ?? "";
                string city = row.Cells["City"]?.Value?.ToString() ?? "";
                string pCode = row.Cells["Postal Code"]?.Value?.ToString() ?? "";

                // Safely combine pieces into a single readable line for your partner's form
                string fullAddress = $"{sNum} {sName}, {suburb}, {city}, {pCode}".Trim(' ', ',');

                // 4. Extract recipient and validation values
                string fName = row.Cells["Recipient First Name"]?.Value?.ToString() ?? "";
                string lName = row.Cells["Recipient Last Name"]?.Value?.ToString() ?? "";
                string recName = $"{fName} {lName}".Trim(); // Merge first and last name together

                string recEmail = row.Cells["Recipient Email"]?.Value?.ToString() ?? "";
                string recRole = row.Cells["Recipient Role"]?.Value?.ToString() ?? "IT Admin"; // Fallback placeholder if missing

                // Check your 'Status' column to dynamically decide if the validation check passes
                string statusText = row.Cells["Status"]?.Value?.ToString() ?? "PENDING";

                // 5. Fire open your partner's popup window with the parameters filled!
                using (var detailsForm = new viewRequest_SystemAdmin(
                    applicationId: applicationId,
                    emis: provCode,
                    name: orgName,
                    email: email,
                    telephone: tel,
                    address: fullAddress, // Sends the perfectly structured location text block
                    province: province,
                    organizationType: orgType,
                    recipientName: recName, // Sends the fully concatenated full name
                    recipientRole: recRole,
                    recipientEmail: recEmail,
                    status: statusText))


                {
                    DialogResult result = detailsForm.ShowDialog(this);


                    if (result == DialogResult.Yes || result == DialogResult.No)
                    {
                        ApplicationDatabase.RefreshOrgGridData(dgvVerifierRequests);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ApplicationDatabase.RefreshOrgGridData(dgvVerifierRequests);
        }

        private void ucVerifyingOrgRequests_Load(object sender, EventArgs e)
        {
            cboSearchBy5.Items.Add("Organization Name");
            cboSearchBy5.Items.Add("Provider Code");
            cboSearchBy5.SelectedIndex = 0;
            ApplicationDatabase.RefreshOrgGridData(dgvVerifierRequests);
        }

        private void txtSearchBy5_TextChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchOrgGridData(dgvVerifierRequests, cboSearchBy5.Text, txtSearchBy5.Text);
        }

        private void cboSearchBy5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchOrgGridData(dgvVerifierRequests, cboSearchBy5.Text, txtSearchBy5.Text);
        }
    }
}
