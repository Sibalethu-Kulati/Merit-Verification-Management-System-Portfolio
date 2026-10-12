namespace Updated_Information_System_3
{
    partial class ucItAdmin_learners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItAdmin_learners));
            button2 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 64);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(566, 602);
            button2.Name = "button2";
            button2.Size = new Size(363, 60);
            button2.TabIndex = 36;
            button2.Text = "Update & Send Login";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(549, 131);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 33;
            label2.Text = "Search By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(656, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 246);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All Learners";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            dataGridView1.Location = new Point(25, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(839, 162);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(36, 29);
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
            label6.Size = new Size(283, 41);
            label6.TabIndex = 0;
            label6.Text = "List Of All Learners";
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
            Column5.HeaderText = "SA ID Number";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 190;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(37, 432);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(892, 155);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student contact details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 37;
            label1.Text = "Student";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(735, 31);
            textBox2.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 31);
            textBox3.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 96);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 39;
            label3.Text = "Email address";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(593, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 31);
            textBox4.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(452, 96);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 41;
            label4.Text = "Phone number";
            // 
            // ucItAdmin_learners
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "ucItAdmin_learners";
            Size = new Size(960, 691);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
    }
}
