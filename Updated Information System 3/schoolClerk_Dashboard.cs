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
        private ucSchoolClerkCertificates ucCerts;

        private ucVerifierDashboard ucVerifier;
        public schoolClerk_Dashboard()
        {
            InitializeComponent();
            ucProfile = NavigationClass.addUserControl<ucProfilePage>(this, panel1);
            ucVerifier = NavigationClass.addUserControl<ucVerifierDashboard>(this, panel1);
            ucCerts = NavigationClass.addUserControl<ucSchoolClerkCertificates>(this, panel1);

        }

        private void schoolClerk_Dashboard_Load(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifier, this);
        }

        private void btn_schoolClerk_Dashboard_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifier, this);
        }

        private void btn_schoolClerk_Profile_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucProfile, this);
        }

        private void btn_learners_schoolClerk_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucSchoolClerkLearners1, this);
        }

        private void btn_certificates_schoolClerk_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucCerts, this);
        }

        private void btn_schoolClerk_LogOut_Click(object sender, EventArgs e)
        {
            NavigationClass.logOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void ucSchoolClerkCertificates1_Load(object sender, EventArgs e)
        {

        }
    }
}
