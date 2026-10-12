namespace Updated_Information_System_3
{
    partial class ucItAdmin_manageStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItAdmin_manageStaff));
            btn_updateSatffMember = new Button();
            btnRemoveStaffMember = new Button();
            btn_addStaffMember = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_updateSatffMember
            // 
            btn_updateSatffMember.BackColor = Color.Green;
            btn_updateSatffMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_updateSatffMember.ForeColor = SystemColors.Window;
            btn_updateSatffMember.Location = new Point(653, 579);
            btn_updateSatffMember.Name = "btn_updateSatffMember";
            btn_updateSatffMember.Size = new Size(264, 60);
            btn_updateSatffMember.TabIndex = 36;
            btn_updateSatffMember.Text = "Update Staff Member";
            btn_updateSatffMember.UseVisualStyleBackColor = false;
            // 
            // btnRemoveStaffMember
            // 
            btnRemoveStaffMember.BackColor = Color.FromArgb(192, 0, 0);
            btnRemoveStaffMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveStaffMember.ForeColor = SystemColors.Window;
            btnRemoveStaffMember.Location = new Point(338, 579);
            btnRemoveStaffMember.Name = "btnRemoveStaffMember";
            btnRemoveStaffMember.Size = new Size(252, 60);
            btnRemoveStaffMember.TabIndex = 35;
            btnRemoveStaffMember.Text = "Remove Staff Member";
            btnRemoveStaffMember.UseVisualStyleBackColor = false;
            // 
            // btn_addStaffMember
            // 
            btn_addStaffMember.BackColor = Color.FromArgb(0, 64, 64);
            btn_addStaffMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addStaffMember.ForeColor = SystemColors.Window;
            btn_addStaffMember.Location = new Point(35, 579);
            btn_addStaffMember.Name = "btn_addStaffMember";
            btn_addStaffMember.Size = new Size(241, 60);
            btn_addStaffMember.TabIndex = 34;
            btn_addStaffMember.Text = "Add Staff Member";
            btn_addStaffMember.UseVisualStyleBackColor = false;
            btn_addStaffMember.Click += btn_addStaffMember_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(546, 141);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 33;
            label2.Text = "Search By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(653, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 328);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All Staff";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            dataGridView1.Location = new Point(25, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(839, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gender";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Role";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 140;
            // 
            // Column6
            // 
            Column6.HeaderText = "Phone";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
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
            panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
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
            label6.Location = new Point(112, 17);
            label6.Name = "label6";
            label6.Size = new Size(208, 41);
            label6.TabIndex = 0;
            label6.Text = "Manage Staff";
            // 
            // ucItAdmin_manageStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_updateSatffMember);
            Controls.Add(btnRemoveStaffMember);
            Controls.Add(btn_addStaffMember);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "ucItAdmin_manageStaff";
            Size = new Size(960, 691);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_updateSatffMember;
        private Button btnRemoveStaffMember;
        private Button btn_addStaffMember;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
    }
}
