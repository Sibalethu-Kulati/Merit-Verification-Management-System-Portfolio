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
            ApplicationDatabase.LoadHighSchools(dgvHighSchools);
        }

        private void dgvHighSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
