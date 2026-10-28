using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucVerifyingOrgsList : UserControl
    {
        public ucVerifyingOrgsList()
        {
            InitializeComponent();
        }

        private void ucVerifyingOrgsList_Load(object sender, EventArgs e)
        {
            cboSearchBy3.Items.Add("Organization Name");
            cboSearchBy3.Items.Add("Provider Code");
            cboSearchBy3.SelectedIndex = 0;
            DataTable dt = ApplicationDatabase.GetInstitutions(false);
            dgvOrganizations.DataSource = dt;
            //ApplicationDatabase.RefreshOrgGridData(dgvOrganizations);
        }

        private void txtSearchBy3_TextChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchOrgGridData(dgvOrganizations, cboSearchBy3.Text, txtSearchBy3.Text);
        }

        private void cboSearchBy3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchOrgGridData(dgvOrganizations, cboSearchBy3.Text, txtSearchBy3.Text);
        }
    }
}
