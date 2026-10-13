using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucSchoolClerk_AddCertificate : UserControl
    {
        public ucSchoolClerk_AddCertificate()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnkBacktoCertificates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationClass.openUserControl(ucToOpen: new ucSchoolClerkCertificates(), parentContainer: this);
        }
    }
}
