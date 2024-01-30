namespace CarRentalManagementSystem
{
    partial class Login
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
            label1 = new Label();
            labAvailable = new Label();
            labModel = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(458, 34);
            label1.TabIndex = 1;
            label1.Text = "Car Rental Management System";
            // 
            // labAvailable
            // 
            labAvailable.AutoSize = true;
            labAvailable.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labAvailable.ForeColor = Color.MidnightBlue;
            labAvailable.Location = new Point(37, 173);
            labAvailable.Name = "labAvailable";
            labAvailable.Size = new Size(142, 34);
            labAvailable.TabIndex = 16;
            labAvailable.Text = "Password";
            // 
            // labModel
            // 
            labModel.AutoSize = true;
            labModel.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labModel.ForeColor = Color.MidnightBlue;
            labModel.Location = new Point(37, 110);
            labModel.Name = "labModel";
            labModel.Size = new Size(153, 34);
            labModel.TabIndex = 17;
            labModel.Text = "UserName";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.Crimson;
            txtUsername.Location = new Point(196, 111);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(323, 37);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(196, 264);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(323, 43);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkShowPassword.ForeColor = Color.MidnightBlue;
            chkShowPassword.Location = new Point(196, 224);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(218, 34);
            chkShowPassword.TabIndex = 26;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(557, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 34);
            label2.TabIndex = 27;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(517, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 34);
            label3.TabIndex = 27;
            label3.Text = "-";
            label3.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Crimson;
            txtPassword.Location = new Point(196, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 37);
            txtPassword.TabIndex = 1;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 371);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(labAvailable);
            Controls.Add(labModel);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labAvailable;
        private Label labModel;
        private TextBox txtUsername;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
    }
}