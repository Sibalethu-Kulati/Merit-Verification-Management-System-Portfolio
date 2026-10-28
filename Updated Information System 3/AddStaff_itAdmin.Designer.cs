namespace Updated_Information_System_3
{
    partial class AddStaff_itAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaff_itAdmin));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtStaffNumber = new TextBox();
            label8 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            label5 = new Label();
            cboRole = new ComboBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtSurname = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            cboGender = new ComboBox();
            btn_addStaffMember_itAdmin = new Button();
            btn_CancelStaffMember = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(37, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 77);
            panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 69);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(162, 12);
            label6.Name = "label6";
            label6.Size = new Size(330, 48);
            label6.TabIndex = 0;
            label6.Text = "Add Staff Member";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStaffNumber);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboRole);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboGender);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 491);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Details";
            // 
            // txtStaffNumber
            // 
            txtStaffNumber.Location = new Point(259, 161);
            txtStaffNumber.Name = "txtStaffNumber";
            txtStaffNumber.Size = new Size(312, 36);
            txtStaffNumber.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(42, 167);
            label8.Name = "label8";
            label8.Size = new Size(168, 30);
            label8.TabIndex = 47;
            label8.Text = "STAFF NUMBER";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(259, 399);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(312, 36);
            txtPhone.TabIndex = 46;
            txtPhone.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 405);
            label7.Name = "label7";
            label7.Size = new Size(161, 30);
            label7.TabIndex = 45;
            label7.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 272);
            label5.Name = "label5";
            label5.Size = new Size(57, 30);
            label5.TabIndex = 44;
            label5.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(259, 264);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(312, 38);
            cboRole.TabIndex = 43;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(259, 332);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 36);
            txtEmail.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 338);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 41;
            label4.Text = "Email Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 216);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 39;
            label3.Text = "Gender";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(259, 104);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(312, 36);
            txtSurname.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 110);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 37;
            label1.Text = "Last Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(259, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 36);
            txtName.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 54);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 35;
            label2.Text = "First Name";
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(259, 208);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(316, 38);
            cboGender.TabIndex = 34;
            // 
            // btn_addStaffMember_itAdmin
            // 
            btn_addStaffMember_itAdmin.BackColor = Color.FromArgb(0, 64, 64);
            btn_addStaffMember_itAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addStaffMember_itAdmin.ForeColor = SystemColors.Window;
            btn_addStaffMember_itAdmin.Location = new Point(395, 622);
            btn_addStaffMember_itAdmin.Name = "btn_addStaffMember_itAdmin";
            btn_addStaffMember_itAdmin.Size = new Size(241, 59);
            btn_addStaffMember_itAdmin.TabIndex = 35;
            btn_addStaffMember_itAdmin.Text = "Add Staff Member";
            btn_addStaffMember_itAdmin.UseVisualStyleBackColor = false;
            btn_addStaffMember_itAdmin.Click += btn_addStaffMember_itAdmin_Click;
            // 
            // btn_CancelStaffMember
            // 
            btn_CancelStaffMember.BackColor = Color.FromArgb(192, 0, 0);
            btn_CancelStaffMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CancelStaffMember.ForeColor = SystemColors.Window;
            btn_CancelStaffMember.Location = new Point(37, 622);
            btn_CancelStaffMember.Name = "btn_CancelStaffMember";
            btn_CancelStaffMember.Size = new Size(241, 59);
            btn_CancelStaffMember.TabIndex = 36;
            btn_CancelStaffMember.Text = "Cancel";
            btn_CancelStaffMember.UseVisualStyleBackColor = false;
            btn_CancelStaffMember.Click += btn_CancelStaffMember_Click;
            // 
            // AddStaff_itAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 693);
            Controls.Add(btn_CancelStaffMember);
            Controls.Add(btn_addStaffMember_itAdmin);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "AddStaff_itAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStaff_itAdmin";
            Load += AddStaff_itAdmin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label6;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cboGender;
        private TextBox txtPhone;
        private Label label7;
        private Label label5;
        private ComboBox cboRole;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private TextBox txtSurname;
        private Label label1;
        private TextBox txtName;
        private Button btn_addStaffMember_itAdmin;
        private Button btn_CancelStaffMember;
        private TextBox txtStaffNumber;
        private Label label8;
    }
}