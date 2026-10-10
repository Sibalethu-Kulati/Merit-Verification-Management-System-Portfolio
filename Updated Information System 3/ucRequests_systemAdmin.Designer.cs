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
            button2 = new Button();
            button1 = new Button();
            btn_viewRequest_systemAdmin = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
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
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(654, 586);
            button2.Name = "button2";
            button2.Size = new Size(264, 60);
            button2.TabIndex = 51;
            button2.Text = "Approve Request";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(339, 586);
            button1.Name = "button1";
            button1.Size = new Size(252, 60);
            button1.TabIndex = 50;
            button1.Text = "Reject Request";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_viewRequest_systemAdmin
            // 
            btn_viewRequest_systemAdmin.BackColor = Color.FromArgb(0, 64, 64);
            btn_viewRequest_systemAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewRequest_systemAdmin.ForeColor = SystemColors.Window;
            btn_viewRequest_systemAdmin.Location = new Point(36, 586);
            btn_viewRequest_systemAdmin.Name = "btn_viewRequest_systemAdmin";
            btn_viewRequest_systemAdmin.Size = new Size(241, 60);
            btn_viewRequest_systemAdmin.TabIndex = 49;
            btn_viewRequest_systemAdmin.Text = "View Request";
            btn_viewRequest_systemAdmin.UseVisualStyleBackColor = false;
            btn_viewRequest_systemAdmin.Click += btn_viewRequest_systemAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(547, 148);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 48;
            label2.Text = "Search By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(654, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 47;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 46;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 328);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of All Requests";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(26, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(829, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "EMIS Number";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email Address";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
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
            // Column6
            // 
            Column6.HeaderText = "Province";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Organization Type";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Recipient Name";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Recipient Name";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Recipient Email";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Request Status";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(35, 39);
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
            // ucRequests_systemAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_viewRequest_systemAdmin);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "ucRequests_systemAdmin";
            Size = new Size(960, 691);
            Load += ucRequests_systemAdmin_Load;
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

        private Button button2;
        private Button button1;
        private Button btn_viewRequest_systemAdmin;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}
