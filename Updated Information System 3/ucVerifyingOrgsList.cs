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
           DataTable dt = ApplicationDatabase.GetInstitutions(false);
            dgvOrganizations.DataSource = dt;
            //ApplicationDatabase.RefreshOrgGridData(dgvOrganizations);
        }
    }
}
