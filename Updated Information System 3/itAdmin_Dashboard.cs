using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class itAdmin_Dashboard : Form
    {
        public itAdmin_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_itAdmin_LogOut_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.logOut();
        }

        private void btn_itAdmin_organizations_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucItAdmin_organizations1, this);
        }

        private void btn_learners_itAdmin_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucItAdmin_learners1, this);
        }

        private void btn_manageStaff_itAdmin_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.openUserControl(ucItAdmin_manageStaff1, this);
        }
    }
}
