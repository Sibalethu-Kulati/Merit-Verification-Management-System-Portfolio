using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    
    public partial class StudentDashboard : Form
    {
        private ucProfilePage ucProfile;
        private ucVerifierDashboard ucVerifierDashboard2;
        public StudentDashboard()
        {
            InitializeComponent();
            ucProfile = NavigationClass.addUserControl<ucProfilePage>(this, panel1);

            ucVerifierDashboard2 = NavigationClass.addUserControl<ucVerifierDashboard>(this, panel1);
        }

        private void btn_student_LogOut_Click(object sender, EventArgs e)
        {
            NavigationClass.logOut();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {         //
            NavigationClass.openUserControl(ucVerifierDashboard2, this);
        }

        private void btn_student_Dashboard_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucVerifierDashboard2, this);
        }

        private void btn_student_Profile_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucProfile, this);
        }

        private void btn_certificates_student_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucStudentCertificates1, this);
        }

        private void btn_verifications_student_Click(object sender, EventArgs e)
        {
            NavigationClass.openUserControl(ucStudentVerifications1, this);
        }
    }
}
