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

        private void ucHighSchools_SystemAdmin_Load(object sender, EventArgs e)
        {
            cboSearchBy2.Items.Add("School Name");
            cboSearchBy2.Items.Add("EMIS Number");
            cboSearchBy2.SelectedIndex = 0;
            ApplicationDatabase.GetInstitutions(true);
            ApplicationDatabase.LoadHighSchools(dgvHighSchools);
        }

        private void txtSearchBy2_TextChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchHighSchools(dgvHighSchools, cboSearchBy2.Text, txtSearchBy2.Text);
        }

        private void cboSearchBy2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchHighSchools(dgvHighSchools, cboSearchBy2.Text, txtSearchBy2.Text);
        }
    }
}
