using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucRequests_systemAdmin : UserControl
    {
        public ucRequests_systemAdmin()
        {
            InitializeComponent();
        }

        private void ucRequests_systemAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_viewRequest_systemAdmin_Click(object sender, EventArgs e)
        {
            new viewRequest_SystemAdmin().ShowDialog();
        }
    }
}
