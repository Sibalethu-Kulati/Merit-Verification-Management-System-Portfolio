using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class itAdminVerifyingOrganisation : Form
    {
        private ucProfilePage ucProfile;
        private ucVerifierItAdminVerifications ucVerifications;

        private ucVerifierDashboard ucDashboard;
        private ucItAdmin_manageStaff ucItAdmin_ManageStaff1;
        private ucHighSchools_SystemAdmin highSchools;
        public itAdminVerifyingOrganisation()
        {
            InitializeComponent();
            ucProfile = NavigationClass.addUserControl<ucProfilePage>(this, panel1);
            ucDashboard = NavigationClass.addUserControl<ucVerifierDashboard>(this, panel1);
            ucItAdmin_ManageStaff1 = NavigationClass.addUserControl<ucItAdmin_manageStaff>(this, panel1);
            highSchools = NavigationClass.addUserControl<ucHighSchools_SystemAdmin>(this, panel1);
            ucVerifications = NavigationClass.addUserControl<ucVerifierItAdminVerifications>(this, panel1);
        }

        private void btn_itAdmin_Profile_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucProfile, this);
        }

        private void btn_itAdmin_Dashboard_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucDashboard, this);
        }

        private void btn_manageStaff_itAdmin_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucItAdmin_ManageStaff1, this);
        }

        private void ucVerifierItAdminVerifications1_Load(object sender, EventArgs e)
        {

        }

        private void btn_itAdmin_LogOut_Click(object sender, EventArgs e)
        {
            NavigationClass.logOut();
        }

        private void btn_itAdmin_organizations_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(highSchools, this);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifications, this);
        }

        private void itAdminVerifyingOrganisation_Load(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucDashboard, this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            button1.Visible = false;
        }
    }
}
