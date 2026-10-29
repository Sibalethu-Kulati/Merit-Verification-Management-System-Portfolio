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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucItAdmin_manageStaff_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }
        private void LoadStaff()
        {
            ApplicationDatabase.LoadStaffForItAdmin(dataGridView1, UserSession.PersonId);
        }
        private void btn_updateSatffMember_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }
    }
}
