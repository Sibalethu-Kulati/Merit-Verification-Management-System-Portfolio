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
            ucHighSchools_SystemAdmin1.Show();
            ucHighSchools_SystemAdmin1.BringToFront();
            // Hide the other user control
            ucRequests_systemAdmin1.Hide();



        }

        private void btn_requests_systemAdmin_Click(object sender, EventArgs e)
        {
            //Show user controls
            ucRequests_systemAdmin1.Show();
            ucRequests_systemAdmin1.BringToFront();
            // Hide the other user control
            ucHighSchools_SystemAdmin1.Hide();
        }
    }
}
