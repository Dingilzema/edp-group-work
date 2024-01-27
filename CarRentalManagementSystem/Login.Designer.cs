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
            password = new TextBox();
            username = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(26, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 22);
            label1.TabIndex = 1;
            label1.Text = "Car Rental Management System";
            // 
            // labAvailable
            // 
            labAvailable.AutoSize = true;
            labAvailable.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labAvailable.ForeColor = Color.MidnightBlue;
            labAvailable.Location = new Point(26, 104);
            labAvailable.Margin = new Padding(2, 0, 2, 0);
            labAvailable.Name = "labAvailable";
            labAvailable.Size = new Size(95, 22);
            labAvailable.TabIndex = 16;
            labAvailable.Text = "Password";
            // 
            // labModel
            // 
            labModel.AutoSize = true;
            labModel.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labModel.ForeColor = Color.MidnightBlue;
            labModel.Location = new Point(26, 66);
            labModel.Margin = new Padding(2, 0, 2, 0);
            labModel.Name = "labModel";
            labModel.Size = new Size(103, 22);
            labModel.TabIndex = 17;
            labModel.Text = "UserName";
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Crimson;
            password.Location = new Point(137, 104);
            password.Margin = new Padding(2, 2, 2, 2);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(227, 27);
            password.TabIndex = 18;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Crimson;
            username.Location = new Point(137, 67);
            username.Margin = new Padding(2, 2, 2, 2);
            username.Name = "username";
            username.Size = new Size(227, 27);
            username.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(137, 158);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(226, 26);
            button1.TabIndex = 25;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.MidnightBlue;
            checkBox1.Location = new Point(137, 134);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 25);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(390, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 23);
            label2.TabIndex = 27;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(362, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 23);
            label3.TabIndex = 27;
            label3.Text = "-";
            label3.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 223);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(labAvailable);
            Controls.Add(labModel);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labAvailable;
        private Label labModel;
        private TextBox password;
        private TextBox username;
        private Button button1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
    }
}