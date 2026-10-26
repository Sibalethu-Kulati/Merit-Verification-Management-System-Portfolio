namespace Updated_Information_System_3
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            btn_addStudent = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            cboGrade = new ComboBox();
            txtIDnumber = new TextBox();
            label4 = new Label();
            txtLSurname = new TextBox();
            label1 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_addStudent
            // 
            btn_addStudent.BackColor = Color.FromArgb(0, 64, 64);
            btn_addStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addStudent.ForeColor = SystemColors.Window;
            btn_addStudent.Location = new Point(408, 569);
            btn_addStudent.Name = "btn_addStudent";
            btn_addStudent.Size = new Size(241, 59);
            btn_addStudent.TabIndex = 39;
            btn_addStudent.Text = "Add Student";
            btn_addStudent.UseVisualStyleBackColor = false;
            btn_addStudent.Click += btn_addStudent_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboGrade);
            groupBox1.Controls.Add(txtIDnumber);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLSurname);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(50, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 413);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "STUDENT DETAILS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 226);
            label5.Name = "label5";
            label5.Size = new Size(72, 30);
            label5.TabIndex = 44;
            label5.Text = "Grade";
            // 
            // cboGrade
            // 
            cboGrade.FormattingEnabled = true;
            cboGrade.Location = new Point(259, 218);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(312, 38);
            cboGrade.TabIndex = 43;
            // 
            // txtIDnumber
            // 
            txtIDnumber.Location = new Point(259, 286);
            txtIDnumber.Name = "txtIDnumber";
            txtIDnumber.Size = new Size(312, 36);
            txtIDnumber.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 292);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 41;
            label4.Text = "ID Number";
            // 
            // txtLSurname
            // 
            txtLSurname.Location = new Point(259, 148);
            txtLSurname.Name = "txtLSurname";
            txtLSurname.Size = new Size(312, 36);
            txtLSurname.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 154);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 37;
            label1.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(259, 92);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(312, 36);
            txtFName.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 98);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 35;
            label2.Text = "First Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(50, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 77);
            panel2.TabIndex = 37;
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
            label6.Size = new Size(291, 48);
            label6.TabIndex = 0;
            label6.Text = "ADD STUDENTS";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 693);
            Controls.Add(btn_addStudent);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "AddStudent";
            Text = "AddStudent";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_addStudent;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cboGrade;
        private TextBox txtIDnumber;
        private Label label4;
        private TextBox txtLSurname;
        private Label label1;
        private TextBox txtFName;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label6;
    }
}