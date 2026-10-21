using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class systemAdmin_Dashboard : Form
    {
        private ucProfilePage ucProfile;

        private ucVerifierDashboard ucDashboard;

        private ucVerifyingOrgRequests ucOrgRequests;
        public systemAdmin_Dashboard()
        {
            InitializeComponent();
            ucProfile = NavigationClass.addUserControl<ucProfilePage>(this, panel1);
            ucDashboard = NavigationClass.addUserControl<ucVerifierDashboard>(this, panel1);
            ucOrgRequests = NavigationClass.addUserControl<ucVerifyingOrgRequests>(this, panel1);
        }

        private void btn_highSchools_systemAdmin_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucHighSchools_SystemAdmin1, this);
        }

        private void btn_requests_systemAdmin_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucRequests_systemAdmin1, this);
        }

        private void systemAdmin_Dashboard_Load(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucDashboard, this);
        }
        

        private void btn_systemAdmin_LogOut_Click(object sender, EventArgs e)
        {
            NavigationClass.logOut();
        }

        private void btn_systemAdmin_Profile_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucProfile, this);
        }

        private void btn_systemAdmin_Dashboard_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucDashboard, this);
        }

        private void btnOrgRequests_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucOrgRequests, this);
        }

        private void ucRequests_systemAdmin1_Load(object sender, EventArgs e)
        {

        }
    }
}
