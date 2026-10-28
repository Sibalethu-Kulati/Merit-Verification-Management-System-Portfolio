namespace Updated_Information_System_3
{
    partial class ucItAdmin_organizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItAdmin_organizations));
            label2 = new Label();
            cboSearchBy1 = new ComboBox();
            txtSearchBy1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(542, 142);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 38;
            label2.Text = "Search By";
            // 
            // cboSearchBy1
            // 
            cboSearchBy1.FormattingEnabled = true;
            cboSearchBy1.Location = new Point(649, 139);
            cboSearchBy1.Name = "cboSearchBy1";
            cboSearchBy1.Size = new Size(273, 33);
            cboSearchBy1.TabIndex = 37;
            cboSearchBy1.SelectedIndexChanged += cboSearchBy1_SelectedIndexChanged;
            // 
            // txtSearchBy1
            // 
            txtSearchBy1.Location = new Point(30, 139);
            txtSearchBy1.Name = "txtSearchBy1";
            txtSearchBy1.Size = new Size(462, 31);
            txtSearchBy1.TabIndex = 36;
            txtSearchBy1.TextChanged += txtSearchBy1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 325);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All Verifying Organizations";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(839, 215);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(30, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 77);
            panel2.TabIndex = 34;
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
            pictureBox3.Location = new Point(663, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(227, 67);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(101, 15);
            label6.Name = "label6";
            label6.Size = new Size(500, 41);
            label6.TabIndex = 0;
            label6.Text = "List Of All Verifying Organizations";
            // 
            // ucItAdmin_organizations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(cboSearchBy1);
            Controls.Add(txtSearchBy1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "ucItAdmin_organizations";
            Size = new Size(960, 691);
            Load += ucItAdmin_organizations_Load;
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

        private Label label2;
        private ComboBox cboSearchBy1;
        private TextBox txtSearchBy1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
    }
}
