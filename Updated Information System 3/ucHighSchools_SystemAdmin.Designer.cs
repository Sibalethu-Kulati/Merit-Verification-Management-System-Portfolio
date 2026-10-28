namespace Updated_Information_System_3
{
    partial class ucHighSchools_SystemAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHighSchools_SystemAdmin));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            btn_AddHighSchool_systemAdmin = new Button();
            label2 = new Label();
            cboSearchBy2 = new ComboBox();
            txtSearchBy2 = new TextBox();
            groupBox1 = new GroupBox();
            dgvHighSchools = new DataGridView();
            EmisNo = new DataGridViewTextBoxColumn();
            highSchool = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHighSchools).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(35, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 77);
            panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 69);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(633, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 67);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(114, 17);
            label6.Name = "label6";
            label6.Size = new Size(349, 41);
            label6.TabIndex = 0;
            label6.Text = "List Of All High Schools";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(654, 576);
            button2.Name = "button2";
            button2.Size = new Size(264, 60);
            button2.TabIndex = 43;
            button2.Text = "Update High School";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(339, 576);
            button1.Name = "button1";
            button1.Size = new Size(252, 60);
            button1.TabIndex = 42;
            button1.Text = "Remove High School";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_AddHighSchool_systemAdmin
            // 
            btn_AddHighSchool_systemAdmin.BackColor = Color.FromArgb(0, 64, 64);
            btn_AddHighSchool_systemAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddHighSchool_systemAdmin.ForeColor = SystemColors.Window;
            btn_AddHighSchool_systemAdmin.Location = new Point(36, 576);
            btn_AddHighSchool_systemAdmin.Name = "btn_AddHighSchool_systemAdmin";
            btn_AddHighSchool_systemAdmin.Size = new Size(241, 60);
            btn_AddHighSchool_systemAdmin.TabIndex = 41;
            btn_AddHighSchool_systemAdmin.Text = "Add High School";
            btn_AddHighSchool_systemAdmin.UseVisualStyleBackColor = false;
            btn_AddHighSchool_systemAdmin.Click += btn_AddHighSchool_systemAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(547, 138);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 40;
            label2.Text = "Search By";
            // 
            // cboSearchBy2
            // 
            cboSearchBy2.FormattingEnabled = true;
            cboSearchBy2.Location = new Point(654, 135);
            cboSearchBy2.Name = "cboSearchBy2";
            cboSearchBy2.Size = new Size(273, 33);
            cboSearchBy2.TabIndex = 39;
            cboSearchBy2.SelectedIndexChanged += cboSearchBy2_SelectedIndexChanged;
            // 
            // txtSearchBy2
            // 
            txtSearchBy2.Location = new Point(35, 135);
            txtSearchBy2.Name = "txtSearchBy2";
            txtSearchBy2.Size = new Size(462, 31);
            txtSearchBy2.TabIndex = 38;
            txtSearchBy2.TextChanged += txtSearchBy2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHighSchools);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 328);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All High Schools";
            // 
            // dgvHighSchools
            // 
            dgvHighSchools.BackgroundColor = Color.WhiteSmoke;
            dgvHighSchools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHighSchools.Columns.AddRange(new DataGridViewColumn[] { EmisNo, highSchool, email, phone, address });
            dgvHighSchools.Location = new Point(26, 56);
            dgvHighSchools.Name = "dgvHighSchools";
            dgvHighSchools.RowHeadersWidth = 51;
            dgvHighSchools.Size = new Size(839, 205);
            dgvHighSchools.TabIndex = 8;
            // 
            // EmisNo
            // 
            EmisNo.HeaderText = "EMIS Number";
            EmisNo.MinimumWidth = 6;
            EmisNo.Name = "EmisNo";
            EmisNo.Width = 190;
            // 
            // highSchool
            // 
            highSchool.HeaderText = "School Name";
            highSchool.MinimumWidth = 6;
            highSchool.Name = "highSchool";
            highSchool.Width = 170;
            // 
            // email
            // 
            email.HeaderText = "Email Address";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 190;
            // 
            // phone
            // 
            phone.HeaderText = "Telephone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 125;
            // 
            // ucHighSchools_SystemAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_AddHighSchool_systemAdmin);
            Controls.Add(label2);
            Controls.Add(cboSearchBy2);
            Controls.Add(txtSearchBy2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "ucHighSchools_SystemAdmin";
            Size = new Size(960, 691);
            Load += ucHighSchools_SystemAdmin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHighSchools).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private Button button2;
        private Button button1;
        private Button btn_AddHighSchool_systemAdmin;
        private Label label2;
        private ComboBox cboSearchBy2;
        private TextBox txtSearchBy2;
        private GroupBox groupBox1;
        private DataGridView dgvHighSchools;
        private DataGridViewTextBoxColumn EmisNo;
        private DataGridViewTextBoxColumn highSchool;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
    }
}
