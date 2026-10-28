using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucItAdmin_organizations : UserControl
    {
        public ucItAdmin_organizations()
        {
            InitializeComponent();
        }

        private void ucItAdmin_organizations_Load(object sender, EventArgs e)
        {
            cboSearchBy1.Items.Add("Organization Name");
            cboSearchBy1.Items.Add("Provider Code");
            cboSearchBy1.SelectedIndex = 0;
            ApplicationDatabase.RefreshOrgGridData(dataGridView1);
        }

        private void txtSearchBy1_TextChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchOrgGridData(dataGridView1, cboSearchBy1.Text, txtSearchBy1.Text);
        }

        private void cboSearchBy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationDatabase.SearchOrgGridData(dataGridView1, cboSearchBy1.Text, txtSearchBy1.Text);
        }
    }
}
