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
        public systemAdmin_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_highSchools_systemAdmin_Click(object sender, EventArgs e)
        {
            // Show user controls
            UTILITY_CLASS.openUserControl(ucHighSchools_SystemAdmin1, this);



        }

        private void btn_requests_systemAdmin_Click(object sender, EventArgs e)
        {
            //Show user controls
            UTILITY_CLASS.openUserControl(ucRequests_systemAdmin1, this);
            ;
        }

        private void systemAdmin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_systemAdmin_LogOut_Click(object sender, EventArgs e)
        {
            UTILITY_CLASS.logOut();
        }
    }
}
