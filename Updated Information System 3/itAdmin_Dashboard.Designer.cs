namespace Updated_Information_System_3
{
    partial class itAdmin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itAdmin_Dashboard));
            panel1 = new Panel();
            btn_manageStaff_itAdmin = new Button();
            pictureBox1 = new PictureBox();
            btn_itAdmin_LogOut = new Button();
            btn_itAdmin_organizations = new Button();
            btn_learners_itAdmin = new Button();
            btn_itAdmin_Profile = new Button();
            btn_itAdmin_Dashboard = new Button();
            ucItAdmin_manageStaff1 = new ucItAdmin_manageStaff();
            ucItAdmin_organizations1 = new ucItAdmin_organizations();
            ucItAdmin_learners1 = new ucItAdmin_learners();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(btn_manageStaff_itAdmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_itAdmin_LogOut);
            panel1.Controls.Add(btn_itAdmin_organizations);
            panel1.Controls.Add(btn_learners_itAdmin);
            panel1.Controls.Add(btn_itAdmin_Profile);
            panel1.Controls.Add(btn_itAdmin_Dashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 691);
            panel1.TabIndex = 2;
            // 
            // btn_manageStaff_itAdmin
            // 
            btn_manageStaff_itAdmin.BackColor = Color.FromArgb(0, 64, 64);
            btn_manageStaff_itAdmin.FlatStyle = FlatStyle.Flat;
            btn_manageStaff_itAdmin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_manageStaff_itAdmin.ForeColor = Color.White;
            btn_manageStaff_itAdmin.Location = new Point(21, 328);
            btn_manageStaff_itAdmin.Name = "btn_manageStaff_itAdmin";
            btn_manageStaff_itAdmin.Size = new Size(229, 60);
            btn_manageStaff_itAdmin.TabIndex = 5;
            btn_manageStaff_itAdmin.Text = "Manage Staff";
            btn_manageStaff_itAdmin.UseVisualStyleBackColor = false;
            btn_manageStaff_itAdmin.Click += btn_manageStaff_itAdmin_Click;
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
            // btn_itAdmin_LogOut
            // 
            btn_itAdmin_LogOut.BackColor = Color.FromArgb(0, 64, 64);
            btn_itAdmin_LogOut.FlatStyle = FlatStyle.Flat;
            btn_itAdmin_LogOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_itAdmin_LogOut.ForeColor = Color.White;
            btn_itAdmin_LogOut.Location = new Point(21, 598);
            btn_itAdmin_LogOut.Name = "btn_itAdmin_LogOut";
            btn_itAdmin_LogOut.Size = new Size(229, 60);
            btn_itAdmin_LogOut.TabIndex = 1;
            btn_itAdmin_LogOut.Text = "Log Out";
            btn_itAdmin_LogOut.UseVisualStyleBackColor = false;
            btn_itAdmin_LogOut.Click += btn_itAdmin_LogOut_Click;
            // 
            // btn_itAdmin_organizations
            // 
            btn_itAdmin_organizations.BackColor = Color.FromArgb(0, 64, 64);
            btn_itAdmin_organizations.FlatStyle = FlatStyle.Flat;
            btn_itAdmin_organizations.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_itAdmin_organizations.ForeColor = Color.White;
            btn_itAdmin_organizations.Location = new Point(21, 486);
            btn_itAdmin_organizations.Name = "btn_itAdmin_organizations";
            btn_itAdmin_organizations.Size = new Size(229, 60);
            btn_itAdmin_organizations.TabIndex = 3;
            btn_itAdmin_organizations.Text = "Organizations";
            btn_itAdmin_organizations.UseVisualStyleBackColor = false;
            btn_itAdmin_organizations.Click += btn_itAdmin_organizations_Click;
            // 
            // btn_learners_itAdmin
            // 
            btn_learners_itAdmin.BackColor = Color.FromArgb(0, 64, 64);
            btn_learners_itAdmin.FlatStyle = FlatStyle.Flat;
            btn_learners_itAdmin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_learners_itAdmin.ForeColor = Color.White;
            btn_learners_itAdmin.Location = new Point(21, 403);
            btn_learners_itAdmin.Name = "btn_learners_itAdmin";
            btn_learners_itAdmin.Size = new Size(229, 60);
            btn_learners_itAdmin.TabIndex = 2;
            btn_learners_itAdmin.Text = "Learners";
            btn_learners_itAdmin.UseVisualStyleBackColor = false;
            btn_learners_itAdmin.Click += btn_learners_itAdmin_Click;
            // 
            // btn_itAdmin_Profile
            // 
            btn_itAdmin_Profile.BackColor = Color.FromArgb(0, 64, 64);
            btn_itAdmin_Profile.FlatStyle = FlatStyle.Flat;
            btn_itAdmin_Profile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_itAdmin_Profile.ForeColor = Color.White;
            btn_itAdmin_Profile.Location = new Point(21, 251);
            btn_itAdmin_Profile.Name = "btn_itAdmin_Profile";
            btn_itAdmin_Profile.Size = new Size(229, 60);
            btn_itAdmin_Profile.TabIndex = 1;
            btn_itAdmin_Profile.Text = "Profile";
            btn_itAdmin_Profile.UseVisualStyleBackColor = false;
            // 
            // btn_itAdmin_Dashboard
            // 
            btn_itAdmin_Dashboard.BackColor = Color.FromArgb(0, 64, 64);
            btn_itAdmin_Dashboard.FlatStyle = FlatStyle.Flat;
            btn_itAdmin_Dashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_itAdmin_Dashboard.ForeColor = Color.White;
            btn_itAdmin_Dashboard.Location = new Point(21, 167);
            btn_itAdmin_Dashboard.Name = "btn_itAdmin_Dashboard";
            btn_itAdmin_Dashboard.Size = new Size(229, 60);
            btn_itAdmin_Dashboard.TabIndex = 0;
            btn_itAdmin_Dashboard.Text = "Dashboard";
            btn_itAdmin_Dashboard.UseVisualStyleBackColor = false;
            // 
            // ucItAdmin_manageStaff1
            // 
            ucItAdmin_manageStaff1.Location = new Point(270, 0);
            ucItAdmin_manageStaff1.Name = "ucItAdmin_manageStaff1";
            ucItAdmin_manageStaff1.Size = new Size(1200, 864);
            ucItAdmin_manageStaff1.TabIndex = 3;
            // 
            // ucItAdmin_organizations1
            // 
            ucItAdmin_organizations1.Location = new Point(270, -13);
            ucItAdmin_organizations1.Name = "ucItAdmin_organizations1";
            ucItAdmin_organizations1.Size = new Size(1200, 864);
            ucItAdmin_organizations1.TabIndex = 4;
            // 
            // ucItAdmin_learners1
            // 
            ucItAdmin_learners1.Location = new Point(270, 0);
            ucItAdmin_learners1.Name = "ucItAdmin_learners1";
            ucItAdmin_learners1.Size = new Size(1200, 864);
            ucItAdmin_learners1.TabIndex = 5;
            // 
            // itAdmin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 691);
            Controls.Add(ucItAdmin_learners1);
            Controls.Add(ucItAdmin_organizations1);
            Controls.Add(ucItAdmin_manageStaff1);
            Controls.Add(panel1);
            Name = "itAdmin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "itAdmin_Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_itAdmin_LogOut;
        private Button btn_itAdmin_organizations;
        private Button btn_learners_itAdmin;
        private Button btn_itAdmin_Profile;
        private Button btn_itAdmin_Dashboard;
        private Button btn_manageStaff_itAdmin;
        private ucItAdmin_manageStaff ucItAdmin_manageStaff1;
        private ucItAdmin_organizations ucItAdmin_organizations1;
        private ucItAdmin_learners ucItAdmin_learners1;
    }
}