using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucHighSchools_SystemAdmin : UserControl
    {
        public ucHighSchools_SystemAdmin()
        {
            InitializeComponent();
        }

        private void btn_AddHighSchool_systemAdmin_Click(object sender, EventArgs e)
        {
            new SchoolRegistration_wizard().ShowDialog();
        }
    }
}
