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
        private ucProfilePage ucVerifierProfile2;
        private ucVerifierHighSchools ucVerifierHighSchools1;
        private ucVerifierVerifyCertificate ucVerifierVerifyCertificate1;
        public verifierRepresentative_Dashboard()
        {
            InitializeComponent();
                               
            ucVerifierDashboard2 = NavigationClass.addUserControl<ucVerifierDashboard>(this, panel1);

            ucVerifierProfile2 = NavigationClass.addUserControl<ucProfilePage>(this, panel1);

            ucVerifierVerifyCertificate1 = NavigationClass.addUserControl<ucVerifierVerifyCertificate>(this, panel1);

            ucVerifierHighSchools1 = NavigationClass.addUserControl<ucVerifierHighSchools>(this, panel1);
        }

        private void verifierRepresentative_Dashboard_Load(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifierDashboard2, this);
        }

        private void btn_verifierRepresentative_Dashboard_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifierDashboard2, this);
        }

        private void btn_verifierRepresentative_Profile_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifierProfile2,this);
        }

        private void btn_verifyCertificate_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifierVerifyCertificate1, this);
        }

        private void btn_verifierRepresentative_HighSchools_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifierHighSchools1, this);
        }

        private void btn_verifierRepresentative_LogOut_Click(object sender, EventArgs e)
        {
            NavigationClass.logOut();
        }

        private void ucVerifierHighSchools1_Load(object sender, EventArgs e)
        {

        }
    }
}
