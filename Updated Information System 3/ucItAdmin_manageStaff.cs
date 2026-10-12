using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucItAdmin_manageStaff : UserControl
    {
        public ucItAdmin_manageStaff()
        {
            InitializeComponent();
        }

        private void btn_addStaffMember_Click(object sender, EventArgs e)
        {
            //new SchoolRegistration_wizard().ShowDialog();
            new AddStaff_itAdmin().ShowDialog();
        }
    }
}
