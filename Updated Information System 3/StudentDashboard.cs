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
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void btn_student_LogOut_Click(object sender, EventArgs e)
        {
            sign_in signInForm1 = new sign_in();
            this.Hide();
            signInForm1.Show();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            //show the student dashboard user control by default on startup
            ucStudentDashboard1.Show();
            ucStudentDashboard1.BringToFront();
            // Hide the other user controls
            ucStudentProfile1.Hide();
            ucStudentCertificates1.Hide();
            ucStudentVerifications1.Hide();
        }

        private void btn_student_Dashboard_Click(object sender, EventArgs e)
        {
            //show the student dashboard 
            ucStudentDashboard1.Show();
            ucStudentDashboard1.BringToFront();
            // Hide the other user controls
            ucStudentProfile1.Hide();
            ucStudentCertificates1.Hide();
            ucStudentVerifications1.Hide();
        }

        private void btn_student_Profile_Click(object sender, EventArgs e)
        {
            //show the student profile 
            ucStudentProfile1.Show();
            ucStudentProfile1.BringToFront();
            // Hide the other user controls
            ucStudentDashboard1.Hide();
            ucStudentCertificates1.Hide();
            ucStudentVerifications1.Hide();
        }

        private void btn_certificates_student_Click(object sender, EventArgs e)
        {
            //show the student certificates 
            ucStudentCertificates1.Show();
            ucStudentCertificates1.BringToFront();
            // Hide the other user controls
            ucStudentDashboard1.Hide();
            ucStudentProfile1.Hide();
            ucStudentVerifications1.Hide();
        }

        private void btn_verifications_student_Click(object sender, EventArgs e)
        {
            //show the student verifications 
            ucStudentVerifications1.Show();
            ucStudentVerifications1.BringToFront();
            // Hide the other user controls
            ucStudentDashboard1.Hide();
            ucStudentProfile1.Hide();
            ucStudentCertificates1.Hide();
        }
    }
}
