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
        public schoolClerk_Dashboard()
        {
            InitializeComponent();
        }

        private void schoolClerk_Dashboard_Load(object sender, EventArgs e)
        {
            // Hide the secondary user controls
            ucSchoolClerkProfile1.Hide();
            ucSchoolClerkLearners1.Hide();
            ucSchoolClerkCertificates1.Hide();

            // Show the dashboard user control by default on startup
            ucSchoolClerkDashboard1.Show();
            ucSchoolClerkDashboard1.BringToFront();
        }

        private void btn_schoolClerk_Dashboard_Click(object sender, EventArgs e)
        {
            //Hide all user controls
            ucSchoolClerkProfile1.Hide();
            ucSchoolClerkLearners1.Hide();
            ucSchoolClerkCertificates1.Hide();
            // Show the school clerk dashboard user control and hide the others
            ucSchoolClerkDashboard1.Show();
            ucSchoolClerkDashboard1.BringToFront();


        }

        private void btn_schoolClerk_Profile_Click(object sender, EventArgs e)
        {
            //Hide all user controls
            ucSchoolClerkDashboard1.Hide();
            ucSchoolClerkLearners1.Hide();
            ucSchoolClerkCertificates1.Hide();
            // Show the school clerk profile user control and hide the others
            ucSchoolClerkProfile1.Show();
            ucSchoolClerkProfile1.BringToFront();
        }

        private void btn_learners_schoolClerk_Click(object sender, EventArgs e)
        {
            //Hide all user controls
            ucSchoolClerkDashboard1.Hide();
            ucSchoolClerkProfile1.Hide();
            ucSchoolClerkCertificates1.Hide();
            // Show the school clerk learners user control and hide the others
            ucSchoolClerkLearners1.Show();
            ucSchoolClerkLearners1.BringToFront();
        }

        private void btn_certificates_schoolClerk_Click(object sender, EventArgs e)
        {
            //Hide all user controls
            ucSchoolClerkDashboard1.Hide();
            ucSchoolClerkProfile1.Hide();
            ucSchoolClerkLearners1.Hide();
            // Show the school clerk certificates user control and hide the others
            ucSchoolClerkCertificates1.Show();
            ucSchoolClerkCertificates1.BringToFront();
        }

        private void btn_schoolClerk_LogOut_Click(object sender, EventArgs e)
        {
            sign_in signInForm = new sign_in();
            this.Hide();
            signInForm.Show();
        }
    }
}
