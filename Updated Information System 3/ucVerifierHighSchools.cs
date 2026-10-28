using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Final_Attempt;

namespace Updated_Information_System_3
{
    [ToolboxItem(true)]
    public partial class ucVerifierHighSchools : UserControl
    {
        public ucVerifierHighSchools()
        {
            InitializeComponent();
        }


        private void ucVerifierHighSchools_Load(object sender, EventArgs e)
        {
            cboSearchBy.Items.Clear();
            cboSearchBy.Items.Add("School Name");
            cboSearchBy.Items.Add("EMIS Number");
            cboSearchBy.SelectedIndex = 0;
            ApplicationDatabase.LoadHighSchools(dgvHighSchools);
        }

        private void dgvHighSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            RunSearch();
        }

        private void cboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunSearch();
        }
        private void RunSearch()
        {
            if (string.IsNullOrWhiteSpace(txtSearchBy.Text))
                ApplicationDatabase.LoadHighSchools(dgvHighSchools);   // empty box = show all
            else
                ApplicationDatabase.SearchHighSchools(dgvHighSchools, cboSearchBy.Text, txtSearchBy.Text);
        }
    }
}
