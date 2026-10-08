using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class schoolClerk_Dashboard : Form
    {
        private ucProfilePage ucProfile;

        private ucVerifierDashboard ucVerifier;
        public schoolClerk_Dashboard()
        {
            InitializeComponent();
            ucProfile = UTILITY_CLASS.addUserControl<ucProfilePage>(this, panel1);

            ucVerifier = UTILITY_CLASS.addUserControl<ucVerifierDashboard>(this, panel1);
        }
 
        private void schoolClerk_Dashboard_Load(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucVerifier, this);
        }

        private void btn_schoolClerk_Dashboard_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucVerifier, this);
        }

        private void btn_schoolClerk_Profile_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucProfile, this);
        }

        private void btn_learners_schoolClerk_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucSchoolClerkLearners1, this);
        }

        private void btn_certificates_schoolClerk_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucSchoolClerkCertificates1, this);
        }

        private void btn_schoolClerk_LogOut_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.logOut();
        }
    }
}
