namespace Updated_Information_System_3
{
    partial class sign_in
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_in));
            btn_signIn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            linkLabel2 = new LinkLabel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_signIn
            // 
            btn_signIn.BackColor = Color.Teal;
            btn_signIn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_signIn.ForeColor = SystemColors.Window;
            btn_signIn.Location = new Point(28, 377);
            btn_signIn.Name = "btn_signIn";
            btn_signIn.Size = new Size(565, 46);
            btn_signIn.TabIndex = 0;
            btn_signIn.Text = "Sign In";
            btn_signIn.UseVisualStyleBackColor = false;
            btn_signIn.Click += btn_signIn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_signIn);
            panel1.Location = new Point(36, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 480);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 436);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 1;
            label1.Text = "Dont have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DarkCyan;
            linkLabel1.Location = new Point(387, 436);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(28, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.DarkCyan;
            linkLabel2.Location = new Point(434, 331);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(159, 25);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 186);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign In ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 52);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 6;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 122);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 7;
            label3.Text = "Password  :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 31);
            textBox2.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(28, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 66);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(157, 16);
            label4.Name = "label4";
            label4.Size = new Size(341, 31);
            label4.TabIndex = 7;
            label4.Text = "SIGN IN INTO YOUR ACCOUNT";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 65);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(255, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(701, 545);
            panel3.TabIndex = 2;
            // 
            // sign_in
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 691);
            Controls.Add(panel3);
            Name = "sign_in";
            Text = "Sign In";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_signIn;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel3;
    }
}
