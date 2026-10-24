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
            ApplicationDatabase.RefreshOrgGridData(dataGridView1);
        }
    }
}
