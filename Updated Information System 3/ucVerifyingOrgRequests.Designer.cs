namespace Updated_Information_System_3
{
    partial class ucVerifyingOrgRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVerifyingOrgRequests));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dgvVerifierRequests = new DataGridView();
            btn_viewRequest_systemAdmin = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVerifierRequests).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(55, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 77);
            panel2.TabIndex = 45;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvVerifierRequests);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(55, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 337);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All Requests";
            // 
            // dgvVerifierRequests
            // 
            dgvVerifierRequests.BackgroundColor = SystemColors.Control;
            dgvVerifierRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerifierRequests.GridColor = SystemColors.Control;
            dgvVerifierRequests.Location = new Point(26, 66);
            dgvVerifierRequests.Name = "dgvVerifierRequests";
            dgvVerifierRequests.ReadOnly = true;
            dgvVerifierRequests.RowHeadersWidth = 51;
            dgvVerifierRequests.Size = new Size(839, 256);
            dgvVerifierRequests.TabIndex = 0;
            // 
            // btn_viewRequest_systemAdmin
            // 
            btn_viewRequest_systemAdmin.BackColor = Color.FromArgb(0, 64, 64);
            btn_viewRequest_systemAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewRequest_systemAdmin.ForeColor = SystemColors.Window;
            btn_viewRequest_systemAdmin.Location = new Point(55, 558);
            btn_viewRequest_systemAdmin.Name = "btn_viewRequest_systemAdmin";
            btn_viewRequest_systemAdmin.Size = new Size(293, 62);
            btn_viewRequest_systemAdmin.TabIndex = 50;
            btn_viewRequest_systemAdmin.Text = "View Request";
            btn_viewRequest_systemAdmin.UseVisualStyleBackColor = false;
            btn_viewRequest_systemAdmin.Click += btn_viewRequest_systemAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(567, 130);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 57;
            label2.Text = "Search By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(674, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 56;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 55;
            // 
            // ucVerifyingOrgRequests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btn_viewRequest_systemAdmin);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "ucVerifyingOrgRequests";
            Size = new Size(1038, 682);
            Load += ucVerifyingOrgRequests_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVerifierRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private GroupBox groupBox1;
        private DataGridView dgvVerifierRequests;
        private Button btn_viewRequest_systemAdmin;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}
