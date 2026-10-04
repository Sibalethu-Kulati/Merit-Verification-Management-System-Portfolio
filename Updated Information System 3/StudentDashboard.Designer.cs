namespace Updated_Information_System_3
{
    partial class StudentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_student_LogOut = new Button();
            btn_verifications_student = new Button();
            btn_certificates_student = new Button();
            btn_student_Profile = new Button();
            btn_student_Dashboard = new Button();
            ucStudentDashboard1 = new ucStudentDashboard();
            ucStudentProfile1 = new ucStudentProfile();
            ucStudentCertificates1 = new ucStudentCertificates();
            ucStudentVerifications1 = new ucStudentVerifications();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_student_LogOut);
            panel1.Controls.Add(btn_verifications_student);
            panel1.Controls.Add(btn_certificates_student);
            panel1.Controls.Add(btn_student_Profile);
            panel1.Controls.Add(btn_student_Dashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 691);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 127);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_student_LogOut
            // 
            btn_student_LogOut.BackColor = Color.FromArgb(0, 64, 64);
            btn_student_LogOut.FlatStyle = FlatStyle.Flat;
            btn_student_LogOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_student_LogOut.ForeColor = Color.White;
            btn_student_LogOut.Location = new Point(21, 607);
            btn_student_LogOut.Name = "btn_student_LogOut";
            btn_student_LogOut.Size = new Size(229, 60);
            btn_student_LogOut.TabIndex = 1;
            btn_student_LogOut.Text = "Log Out";
            btn_student_LogOut.UseVisualStyleBackColor = false;
            btn_student_LogOut.Click += btn_student_LogOut_Click;
            // 
            // btn_verifications_student
            // 
            btn_verifications_student.BackColor = Color.FromArgb(0, 64, 64);
            btn_verifications_student.FlatStyle = FlatStyle.Flat;
            btn_verifications_student.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_verifications_student.ForeColor = Color.White;
            btn_verifications_student.Location = new Point(21, 425);
            btn_verifications_student.Name = "btn_verifications_student";
            btn_verifications_student.Size = new Size(229, 60);
            btn_verifications_student.TabIndex = 3;
            btn_verifications_student.Text = "Verifications";
            btn_verifications_student.UseVisualStyleBackColor = false;
            btn_verifications_student.Click += btn_verifications_student_Click;
            // 
            // btn_certificates_student
            // 
            btn_certificates_student.BackColor = Color.FromArgb(0, 64, 64);
            btn_certificates_student.FlatStyle = FlatStyle.Flat;
            btn_certificates_student.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_certificates_student.ForeColor = Color.White;
            btn_certificates_student.Location = new Point(21, 342);
            btn_certificates_student.Name = "btn_certificates_student";
            btn_certificates_student.Size = new Size(229, 60);
            btn_certificates_student.TabIndex = 2;
            btn_certificates_student.Text = "Certificates";
            btn_certificates_student.UseVisualStyleBackColor = false;
            btn_certificates_student.Click += btn_certificates_student_Click;
            // 
            // btn_student_Profile
            // 
            btn_student_Profile.BackColor = Color.FromArgb(0, 64, 64);
            btn_student_Profile.FlatStyle = FlatStyle.Flat;
            btn_student_Profile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_student_Profile.ForeColor = Color.White;
            btn_student_Profile.Location = new Point(21, 261);
            btn_student_Profile.Name = "btn_student_Profile";
            btn_student_Profile.Size = new Size(229, 60);
            btn_student_Profile.TabIndex = 1;
            btn_student_Profile.Text = "Profile";
            btn_student_Profile.UseVisualStyleBackColor = false;
            btn_student_Profile.Click += btn_student_Profile_Click;
            // 
            // btn_student_Dashboard
            // 
            btn_student_Dashboard.BackColor = Color.FromArgb(0, 64, 64);
            btn_student_Dashboard.FlatStyle = FlatStyle.Flat;
            btn_student_Dashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_student_Dashboard.ForeColor = Color.White;
            btn_student_Dashboard.Location = new Point(21, 177);
            btn_student_Dashboard.Name = "btn_student_Dashboard";
            btn_student_Dashboard.Size = new Size(229, 60);
            btn_student_Dashboard.TabIndex = 0;
            btn_student_Dashboard.Text = "Dashboard";
            btn_student_Dashboard.UseVisualStyleBackColor = false;
            btn_student_Dashboard.Click += btn_student_Dashboard_Click;
            // 
            // ucStudentDashboard1
            // 
            ucStudentDashboard1.BackColor = Color.FromArgb(0, 64, 64);
            ucStudentDashboard1.Location = new Point(266, 0);
            ucStudentDashboard1.Name = "ucStudentDashboard1";
            ucStudentDashboard1.Size = new Size(1200, 864);
            ucStudentDashboard1.TabIndex = 3;
            // 
            // ucStudentProfile1
            // 
            ucStudentProfile1.BackColor = Color.WhiteSmoke;
            ucStudentProfile1.Location = new Point(276, 0);
            ucStudentProfile1.Name = "ucStudentProfile1";
            ucStudentProfile1.Size = new Size(1200, 864);
            ucStudentProfile1.TabIndex = 4;
            // 
            // ucStudentCertificates1
            // 
            ucStudentCertificates1.Location = new Point(276, -13);
            ucStudentCertificates1.Name = "ucStudentCertificates1";
            ucStudentCertificates1.Size = new Size(1200, 864);
            ucStudentCertificates1.TabIndex = 5;
            // 
            // ucStudentVerifications1
            // 
            ucStudentVerifications1.Location = new Point(276, -13);
            ucStudentVerifications1.Name = "ucStudentVerifications1";
            ucStudentVerifications1.Size = new Size(1200, 864);
            ucStudentVerifications1.TabIndex = 6;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 691);
            Controls.Add(ucStudentVerifications1);
            Controls.Add(ucStudentCertificates1);
            Controls.Add(ucStudentProfile1);
            Controls.Add(ucStudentDashboard1);
            Controls.Add(panel1);
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashboard";
            Load += StudentDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_student_LogOut;
        private Button btn_verifications_student;
        private Button btn_certificates_student;
        private Button btn_student_Profile;
        private Button btn_student_Dashboard;
        private ucStudentDashboard ucStudentDashboard1;
        private ucStudentProfile ucStudentProfile1;
        private ucStudentCertificates ucStudentCertificates1;
        private ucStudentVerifications ucStudentVerifications1;
    }
}