using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucSchoolClerkLearners : UserControl
    {
        public ucSchoolClerkLearners()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            
        }
    }
}
