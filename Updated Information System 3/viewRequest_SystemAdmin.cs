using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
   
    public partial class viewRequest_SystemAdmin : Form
    {
        private void CloseRequest()
        {
            DialogResult = DialogResult.Cancel;
        }
       
        private void RejectRequest()
        {
            if (!_canReview)
            {
                MessageBox.Show(
                    "This request has already been " + _status.ToLower() + ".",
                    "Cannot Reject",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (_applicationId <= 0 || UserSession.PersonId <= 0)
            {
                MessageBox.Show(
                    "Application ID or logged-in administrator ID is missing.",
                    "Cannot Reject",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to reject this request?",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                bool updated = ApplicationDatabase.UpdateApplicationStatus(
                    _applicationId,
                    true,
                    "REJECTED",
                    UserSession.PersonId);

                if (!updated)
                {
                    MessageBox.Show(
                        "The request was not updated. It may already have been reviewed.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "Request rejected successfully.",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.No;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error rejecting request: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ApproveRequest()
        {
            if (!_canReview)
            {
                MessageBox.Show(
                    "This request has already been " + _status.ToLower() + ".",
                    "Cannot Approve",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (_applicationId <= 0 || UserSession.PersonId <= 0)
            {
                MessageBox.Show(
                    "Application ID or logged-in administrator ID is missing.",
                    "Cannot Approve",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to approve this request?",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                bool updated = ApplicationDatabase.UpdateApplicationStatus(
                    _applicationId,
                    true,
                    "APPROVED",
                    UserSession.PersonId);

                if (!updated)
                {
                    MessageBox.Show(
                        "The request was not updated. It may already have been reviewed.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "Request approved successfully.",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.Yes;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error approving request: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
        private readonly string _status;

        private readonly bool _canReview;
        private readonly int _applicationId;
        public viewRequest_SystemAdmin(
            int applicationId = 0,string emis = "",string name = "",string email = "",string telephone = "",
            string address = "",string province = "",string organizationType = "",string recipientName = "",
            string recipientRole = "",string recipientEmail = "",string status = "PENDING")
            
        {
            InitializeComponent();
            _applicationId = applicationId;

            _status = (status ?? "PENDING").ToUpper();
            _canReview = _status == "PENDING";

           ViewRequestIUI_Class.ConfigureForm(this);

            // ----- Teal header -----
            var header = ViewRequestIUI_Class.CreateHeader();

            // ----- Body: two group boxes + status -----
            var bodyControls = ViewRequestIUI_Class.CreateBody(emis,name,email,telephone,address,province,organizationType,recipientName,
                recipientRole,recipientEmail,_status,_canReview);

            var body = bodyControls.Body;
                        
            // ----- Footer: Close on the left, Reject + Approve on the right -----
            var footerControls = ViewRequestIUI_Class.CreateFooter(_canReview);

            var footer = footerControls.Footer;
            var close = footerControls.CloseButton;
            var reject = footerControls.RejectButton;
            var approve = footerControls.ApproveButton;

            close.Click += (s, e) => CloseRequest();


            reject.Click += (s, e) => RejectRequest();


            approve.Click += (s, e) => ApproveRequest();
            

            // Fill goes in first so the Top and Bottom panels claim their space before it.
            Controls.Add(body);
            Controls.Add(header);
            Controls.Add(footer);
        }

        
        private void viewRequest_SystemAdmin_Load(object sender, EventArgs e)
        {

        }
       
    }
}