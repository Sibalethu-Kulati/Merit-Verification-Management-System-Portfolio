namespace Updated_Information_System_3
{
    partial class ucVerifierHighSchools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVerifierHighSchools));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(35, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 67);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 65);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(94, 16);
            label1.Name = "label1";
            label1.Size = new Size(344, 41);
            label1.TabIndex = 1;
            label1.Text = "List of All High Schools";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(638, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 67);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(25, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(846, 278);
            dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 372);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All High Schools";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(657, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(550, 144);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 11;
            label2.Text = "Search By";
            // 
            // Column1
            // 
            Column1.HeaderText = "EMIS Number";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 190;
            // 
            // Column2
            // 
            Column2.HeaderText = "School Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email Address";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 190;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telephone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Address";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // ucVerifierHighSchools
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ucVerifierHighSchools";
            Size = new Size(957, 687);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
