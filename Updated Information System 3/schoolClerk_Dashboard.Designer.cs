namespace Updated_Information_System_3
{
    partial class schoolClerk_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schoolClerk_Dashboard));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btn_schoolClerk_LogOut = new Button();
            btn_certificates_schoolClerk = new Button();
            btn_learners_schoolClerk = new Button();
            btn_schoolClerk_Profile = new Button();
            btn_schoolClerk_Dashboard = new Button();
            ucSchoolClerkDashboard1 = new ucSchoolClerkDashboard();
            ucSchoolClerkProfile1 = new ucSchoolClerkProfile();
            ucSchoolClerkLearners1 = new ucSchoolClerkLearners();
            ucSchoolClerkCertificates1 = new ucSchoolClerkCertificates();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_schoolClerk_LogOut);
            panel1.Controls.Add(btn_certificates_schoolClerk);
            panel1.Controls.Add(btn_learners_schoolClerk);
            panel1.Controls.Add(btn_schoolClerk_Profile);
            panel1.Controls.Add(btn_schoolClerk_Dashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 691);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 493);
            button1.Name = "button1";
            button1.Size = new Size(229, 71);
            button1.TabIndex = 5;
            button1.Text = "ADD CERTIFICATES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 127);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_schoolClerk_LogOut
            // 
            btn_schoolClerk_LogOut.BackColor = Color.FromArgb(0, 64, 64);
            btn_schoolClerk_LogOut.FlatStyle = FlatStyle.Flat;
            btn_schoolClerk_LogOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_schoolClerk_LogOut.ForeColor = Color.White;
            btn_schoolClerk_LogOut.Location = new Point(21, 581);
            btn_schoolClerk_LogOut.Name = "btn_schoolClerk_LogOut";
            btn_schoolClerk_LogOut.Size = new Size(229, 60);
            btn_schoolClerk_LogOut.TabIndex = 1;
            btn_schoolClerk_LogOut.Text = "Log Out";
            btn_schoolClerk_LogOut.UseVisualStyleBackColor = false;
            btn_schoolClerk_LogOut.Click += btn_schoolClerk_LogOut_Click;
            // 
            // btn_certificates_schoolClerk
            // 
            btn_certificates_schoolClerk.BackColor = Color.FromArgb(0, 64, 64);
            btn_certificates_schoolClerk.FlatStyle = FlatStyle.Flat;
            btn_certificates_schoolClerk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_certificates_schoolClerk.ForeColor = Color.White;
            btn_certificates_schoolClerk.Location = new Point(21, 415);
            btn_certificates_schoolClerk.Name = "btn_certificates_schoolClerk";
            btn_certificates_schoolClerk.Size = new Size(229, 60);
            btn_certificates_schoolClerk.TabIndex = 3;
            btn_certificates_schoolClerk.Text = "Certificates";
            btn_certificates_schoolClerk.UseVisualStyleBackColor = false;
            btn_certificates_schoolClerk.Click += btn_certificates_schoolClerk_Click;
            // 
            // btn_learners_schoolClerk
            // 
            btn_learners_schoolClerk.BackColor = Color.FromArgb(0, 64, 64);
            btn_learners_schoolClerk.FlatStyle = FlatStyle.Flat;
            btn_learners_schoolClerk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_learners_schoolClerk.ForeColor = Color.White;
            btn_learners_schoolClerk.Location = new Point(21, 336);
            btn_learners_schoolClerk.Name = "btn_learners_schoolClerk";
            btn_learners_schoolClerk.Size = new Size(229, 60);
            btn_learners_schoolClerk.TabIndex = 2;
            btn_learners_schoolClerk.Text = "Learners";
            btn_learners_schoolClerk.UseVisualStyleBackColor = false;
            btn_learners_schoolClerk.Click += btn_learners_schoolClerk_Click;
            // 
            // btn_schoolClerk_Profile
            // 
            btn_schoolClerk_Profile.BackColor = Color.FromArgb(0, 64, 64);
            btn_schoolClerk_Profile.FlatStyle = FlatStyle.Flat;
            btn_schoolClerk_Profile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_schoolClerk_Profile.ForeColor = Color.White;
            btn_schoolClerk_Profile.Location = new Point(21, 251);
            btn_schoolClerk_Profile.Name = "btn_schoolClerk_Profile";
            btn_schoolClerk_Profile.Size = new Size(229, 60);
            btn_schoolClerk_Profile.TabIndex = 1;
            btn_schoolClerk_Profile.Text = "Profile";
            btn_schoolClerk_Profile.UseVisualStyleBackColor = false;
            btn_schoolClerk_Profile.Click += btn_schoolClerk_Profile_Click;
            // 
            // btn_schoolClerk_Dashboard
            // 
            btn_schoolClerk_Dashboard.BackColor = Color.FromArgb(0, 64, 64);
            btn_schoolClerk_Dashboard.FlatStyle = FlatStyle.Flat;
            btn_schoolClerk_Dashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_schoolClerk_Dashboard.ForeColor = Color.White;
            btn_schoolClerk_Dashboard.Location = new Point(21, 167);
            btn_schoolClerk_Dashboard.Name = "btn_schoolClerk_Dashboard";
            btn_schoolClerk_Dashboard.Size = new Size(229, 60);
            btn_schoolClerk_Dashboard.TabIndex = 0;
            btn_schoolClerk_Dashboard.Text = "Dashboard";
            btn_schoolClerk_Dashboard.UseVisualStyleBackColor = false;
            btn_schoolClerk_Dashboard.Click += btn_schoolClerk_Dashboard_Click;
            // 
            // ucSchoolClerkDashboard1
            // 
            ucSchoolClerkDashboard1.BackColor = Color.FromArgb(0, 64, 64);
            ucSchoolClerkDashboard1.Location = new Point(267, -10);
            ucSchoolClerkDashboard1.Name = "ucSchoolClerkDashboard1";
            ucSchoolClerkDashboard1.Size = new Size(1200, 865);
            ucSchoolClerkDashboard1.TabIndex = 2;
            // 
            // ucSchoolClerkProfile1
            // 
            ucSchoolClerkProfile1.BackColor = Color.WhiteSmoke;
            ucSchoolClerkProfile1.Location = new Point(276, 0);
            ucSchoolClerkProfile1.Name = "ucSchoolClerkProfile1";
            ucSchoolClerkProfile1.Size = new Size(1200, 864);
            ucSchoolClerkProfile1.TabIndex = 3;
            // 
            // ucSchoolClerkLearners1
            // 
            ucSchoolClerkLearners1.Location = new Point(276, 0);
            ucSchoolClerkLearners1.Name = "ucSchoolClerkLearners1";
            ucSchoolClerkLearners1.Size = new Size(1200, 864);
            ucSchoolClerkLearners1.TabIndex = 4;
            // 
            // ucSchoolClerkCertificates1
            // 
            ucSchoolClerkCertificates1.Location = new Point(276, 0);
            ucSchoolClerkCertificates1.Name = "ucSchoolClerkCertificates1";
            ucSchoolClerkCertificates1.Size = new Size(1200, 864);
            ucSchoolClerkCertificates1.TabIndex = 5;
            ucSchoolClerkCertificates1.Load += ucSchoolClerkCertificates1_Load;
            // 
            // schoolClerk_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 691);
            Controls.Add(ucSchoolClerkCertificates1);
            Controls.Add(ucSchoolClerkLearners1);
            Controls.Add(ucSchoolClerkProfile1);
            Controls.Add(ucSchoolClerkDashboard1);
            Controls.Add(panel1);
            Name = "schoolClerk_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "schoolClerk_Dashboard";
            Load += schoolClerk_Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_schoolClerk_LogOut;
        private Button btn_certificates_schoolClerk;
        private Button btn_learners_schoolClerk;
        private Button btn_schoolClerk_Profile;
        private Button btn_schoolClerk_Dashboard;
        private ucSchoolClerkDashboard ucSchoolClerkDashboard1;
        private ucSchoolClerkProfile ucSchoolClerkProfile1;
        private ucSchoolClerkLearners ucSchoolClerkLearners1;
        private ucSchoolClerkCertificates ucSchoolClerkCertificates1;
        private Button button1;
    }
}