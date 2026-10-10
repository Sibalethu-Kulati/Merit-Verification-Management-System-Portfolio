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
            panel2 = new Panel();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lnkForgotPassword = new LinkLabel();
            checkBox1 = new CheckBox();
            lnkSignUp = new LinkLabel();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Controls.Add(lnkForgotPassword);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(lnkSignUp);
            panel1.Controls.Add(btn_signIn);
            panel1.Location = new Point(36, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 480);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
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
            label4.Location = new Point(68, 12);
            label4.Name = "label4";
            label4.Size = new Size(341, 31);
            label4.TabIndex = 7;
            label4.Text = "SIGN IN INTO YOUR ACCOUNT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
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
            // txtPassword
            // 
            txtPassword.Location = new Point(164, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(368, 31);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(164, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(368, 31);
            txtUsername.TabIndex = 8;
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
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkForgotPassword.LinkColor = Color.DarkCyan;
            lnkForgotPassword.Location = new Point(406, 331);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(159, 25);
            lnkForgotPassword.TabIndex = 4;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
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
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkSignUp.LinkColor = Color.DarkCyan;
            lnkSignUp.Location = new Point(158, 426);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(274, 25);
            lnkSignUp.TabIndex = 2;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Don't have an account? Sign Up";
            lnkSignUp.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(244, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(701, 545);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(1052, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 64);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sign_in
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 691);
            Controls.Add(button1);
            Controls.Add(panel3);
            Name = "sign_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += sign_in_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_signIn;
        private Panel panel1;
        private LinkLabel lnkSignUp;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private LinkLabel lnkForgotPassword;
        private CheckBox checkBox1;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Button button1;
    }
}
