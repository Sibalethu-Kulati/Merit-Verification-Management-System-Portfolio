namespace Updated_Information_System_3
{
    partial class ucProfilePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProfilePage));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            btnEdit = new Button();
            txtPhone = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtGender = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(118, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 68);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(292, 16);
            label2.Name = "label2";
            label2.Size = new Size(130, 48);
            label2.TabIndex = 3;
            label2.Text = "Profile";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(1, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(93, 68);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtGender);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(118, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 554);
            panel2.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 64, 0);
            btnEdit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.Window;
            btnEdit.Location = new Point(74, 480);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(233, 46);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(264, 376);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(400, 31);
            txtPhone.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 373);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 8;
            label7.Text = "Phone:";
            label7.Click += label7_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(264, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(400, 31);
            txtEmail.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(64, 276);
            label6.Name = "label6";
            label6.Size = new Size(76, 32);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(264, 191);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(400, 31);
            txtGender.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 191);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(264, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(400, 31);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 110);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 2;
            label4.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(264, 33);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(401, 31);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 33);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 0;
            label3.Text = "First Name:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 64, 64);
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Window;
            btnSave.Location = new Point(406, 480);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(239, 46);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ucProfilePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucProfilePage";
            Size = new Size(960, 691);
            Load += ucVerifierProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label2;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtGender;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtPhone;
        private Label label7;
        private Button btnEdit;
        private Button btnSave;
    }
}
