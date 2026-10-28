using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucSchoolClerkCertificates : UserControl
    {
        
        public ucSchoolClerkCertificates()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var addCert = new ucSchoolClerk_AddCertificate())
            using (var dialog = new Form())
            {
                dialog.Text = "Add Certificate";
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.ShowInTaskbar = false;
                dialog.ClientSize = addCert.Size;

                addCert.Dock = DockStyle.Fill;
                addCert.BringToFront();
                dialog.Controls.Add(addCert);

                dialog.ShowDialog(this);
            }
        }
    }
}
