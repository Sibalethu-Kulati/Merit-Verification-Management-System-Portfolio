namespace Updated_Information_System_3
{
    partial class ucRequests_systemAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRequests_systemAdmin));
            btn_viewRequest_systemAdmin = new Button();
            groupBox1 = new GroupBox();
            dgvRequests = new DataGridView();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_viewRequest_systemAdmin
            // 
            btn_viewRequest_systemAdmin.BackColor = Color.FromArgb(0, 64, 64);
            btn_viewRequest_systemAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewRequest_systemAdmin.ForeColor = SystemColors.Window;
            btn_viewRequest_systemAdmin.Location = new Point(61, 602);
            btn_viewRequest_systemAdmin.Name = "btn_viewRequest_systemAdmin";
            btn_viewRequest_systemAdmin.Size = new Size(257, 59);
            btn_viewRequest_systemAdmin.TabIndex = 49;
            btn_viewRequest_systemAdmin.Text = "View Request";
            btn_viewRequest_systemAdmin.UseVisualStyleBackColor = false;
            btn_viewRequest_systemAdmin.Click += btn_viewRequest_systemAdmin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvRequests);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 337);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All Requests";
            // 
            // dgvRequests
            // 
            dgvRequests.BackgroundColor = SystemColors.Control;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.GridColor = SystemColors.Control;
            dgvRequests.Location = new Point(26, 66);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.Size = new Size(839, 256);
            dgvRequests.TabIndex = 0;
            dgvRequests.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(35, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 77);
            panel2.TabIndex = 44;
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
            label6.Size = new Size(291, 41);
            label6.TabIndex = 0;
            label6.Text = "List Of All Requests";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(547, 153);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 54;
            label2.Text = "Search By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(654, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 52;
            // 
            // ucRequests_systemAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btn_viewRequest_systemAdmin);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "ucRequests_systemAdmin";
            Size = new Size(1092, 719);
            Load += ucRequests_systemAdmin_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_viewRequest_systemAdmin;
        private GroupBox groupBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private DataGridView dgvRequests;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}
