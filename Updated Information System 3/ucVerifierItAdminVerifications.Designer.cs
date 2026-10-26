namespace Updated_Information_System_3
{
    partial class ucVerifierItAdminVerifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVerifierItAdminVerifications));
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dgvHighSchools = new DataGridView();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHighSchools).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(543, 148);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 16;
            label2.Text = "Search By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(650, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHighSchools);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(31, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 372);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All Verifications";
            // 
            // dgvHighSchools
            // 
            dgvHighSchools.BackgroundColor = Color.WhiteSmoke;
            dgvHighSchools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHighSchools.Location = new Point(23, 59);
            dgvHighSchools.Name = "dgvHighSchools";
            dgvHighSchools.RowHeadersWidth = 51;
            dgvHighSchools.Size = new Size(863, 277);
            dgvHighSchools.TabIndex = 7;
            dgvHighSchools.CellContentClick += dgvHighSchools_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(28, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 81);
            panel1.TabIndex = 12;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(89, 18);
            label1.Name = "label1";
            label1.Size = new Size(356, 45);
            label1.TabIndex = 1;
            label1.Text = "List of All Verifications";
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
            // ucVerifierItAdminVerifications
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ucVerifierItAdminVerifications";
            Size = new Size(957, 687);
            Load += ucVerifierItAdminVerifications_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHighSchools).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private DataGridView dgvHighSchools;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
