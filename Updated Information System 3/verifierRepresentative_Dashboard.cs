using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class verifierRepresentative_Dashboard : Form

    {
        
        // Declarations for user controls referenced by this form.
        private ucVerifierDashboard ucVerifierDashboard2;
        private ucVerifierProfile ucVerifierProfile2;
        private ucVerifierHighSchools ucVerifierHighSchools1;
        private ucVerifierVerifyCertificate ucVerifierVerifyCertificate1;
        public verifierRepresentative_Dashboard()
        {
            InitializeComponent();
            
            // Instantiate and add all verifier user controls (designer does not add them)
            var rightX = panel1.Width; // left panel width
            var contentSize = new Size(ClientSize.Width - rightX, ClientSize.Height);

            ucVerifierDashboard2 = new ucVerifierDashboard();
            ucVerifierDashboard2.Location = new Point(rightX, 0);
            ucVerifierDashboard2.Size = contentSize;
            ucVerifierDashboard2.Name = "ucVerifierDashboard2";
            Controls.Add(ucVerifierDashboard2);

            ucVerifierProfile2 = new ucVerifierProfile();
            ucVerifierProfile2.Location = new Point(rightX, 0);
            ucVerifierProfile2.Size = contentSize;
            ucVerifierProfile2.Name = "ucVerifierProfile2";
            Controls.Add(ucVerifierProfile2);

            ucVerifierVerifyCertificate1 = new ucVerifierVerifyCertificate();
            ucVerifierVerifyCertificate1.Location = new Point(rightX, 0);
            ucVerifierVerifyCertificate1.Size = contentSize;
            ucVerifierVerifyCertificate1.Name = "ucVerifierVerifyCertificate1";
            Controls.Add(ucVerifierVerifyCertificate1);

            ucVerifierHighSchools1 = new ucVerifierHighSchools();
            ucVerifierHighSchools1.Location = new Point(rightX, 0);
            ucVerifierHighSchools1.Size = contentSize;
            ucVerifierHighSchools1.Name = "ucVerifierHighSchools1";
            Controls.Add(ucVerifierHighSchools1);
        }

        private void verifierRepresentative_Dashboard_Load(object sender, EventArgs e)
        {
            // Show dashboard by default and hide the other panels
            ucVerifierProfile2.Hide();
            ucVerifierVerifyCertificate1.Hide();
            ucVerifierHighSchools1.Hide();
            ucVerifierDashboard2.Show();
            ucVerifierDashboard2.BringToFront();
        }

        private void btn_verifierRepresentative_Dashboard_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            ucVerifierProfile2.Hide();
            ucVerifierVerifyCertificate1.Hide();
            ucVerifierHighSchools1.Hide();
            //Show the dashboard user control
            ucVerifierDashboard2.Show();
            ucVerifierDashboard2.BringToFront();
        }

        private void btn_verifierRepresentative_Profile_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            ucVerifierDashboard2.Hide();
            ucVerifierVerifyCertificate1.Hide();
            ucVerifierHighSchools1.Hide();
            //Show the profile user control
            ucVerifierProfile2.Show();
            ucVerifierProfile2.BringToFront();
        }

        private void btn_verifyCertificate_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            ucVerifierDashboard2.Hide();
            ucVerifierProfile2.Hide();
            ucVerifierHighSchools1.Hide();
            //Show the verify certificate user control
            ucVerifierVerifyCertificate1.Show();
            ucVerifierVerifyCertificate1.BringToFront();
        }

        private void btn_verifierRepresentative_HighSchools_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            ucVerifierDashboard2.Hide();
            ucVerifierProfile2.Hide();
            ucVerifierVerifyCertificate1.Hide();
            //Show the high schools user control
            ucVerifierHighSchools1.Show();
            ucVerifierHighSchools1.BringToFront();
        }

        private void btn_verifierRepresentative_LogOut_Click(object sender, EventArgs e)
        {
           UserSession.Clear();
           Application.Restart();
        }

        private void ucVerifierHighSchools1_Load(object sender, EventArgs e)
        {

        }
    }
}
