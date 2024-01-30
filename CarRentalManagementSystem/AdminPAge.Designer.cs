namespace CarRentalManagementSystem
{
    partial class AdminPAge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPAge));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            label3 = new Label();
            labAvailable = new Label();
            labModel = new Label();
            labCarList = new Label();
            txtPassword = new TextBox();
            txtEmployee = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            labUser = new Label();
            labCarRental = new Label();
            pictureBox1 = new PictureBox();
            pBoxCar = new PictureBox();
            dgvEmployee = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Navy;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(811, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 43);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Navy;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(655, 271);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 43);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Navy;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(523, 271);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(380, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(1323, 72);
            panel3.TabIndex = 38;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(547, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(547, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(210, 5);
            panel6.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(602, 15);
            label3.Name = "label3";
            label3.Size = new Size(163, 34);
            label3.TabIndex = 1;
            label3.Text = "Employees";
            // 
            // labAvailable
            // 
            labAvailable.AutoSize = true;
            labAvailable.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labAvailable.ForeColor = Color.Crimson;
            labAvailable.Location = new Point(703, 159);
            labAvailable.Name = "labAvailable";
            labAvailable.Size = new Size(142, 34);
            labAvailable.TabIndex = 29;
            labAvailable.Text = "Password";
            // 
            // labModel
            // 
            labModel.AutoSize = true;
            labModel.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labModel.ForeColor = Color.Crimson;
            labModel.Location = new Point(36, 159);
            labModel.Name = "labModel";
            labModel.Size = new Size(242, 34);
            labModel.TabIndex = 30;
            labModel.Text = "Employee Name";
            // 
            // labCarList
            // 
            labCarList.AutoSize = true;
            labCarList.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labCarList.ForeColor = Color.Crimson;
            labCarList.Location = new Point(527, 317);
            labCarList.Name = "labCarList";
            labCarList.Size = new Size(268, 43);
            labCarList.TabIndex = 32;
            labCarList.Text = "Employees List";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Crimson;
            txtPassword.Location = new Point(703, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(560, 37);
            txtPassword.TabIndex = 1;
            // 
            // txtEmployee
            // 
            txtEmployee.BackColor = Color.White;
            txtEmployee.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployee.ForeColor = Color.Crimson;
            txtEmployee.Location = new Point(36, 209);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(549, 37);
            txtEmployee.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labUser);
            panel1.Controls.Add(labCarRental);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pBoxCar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 53);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.Location = new Point(36, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 51);
            panel2.TabIndex = 3;
            // 
            // labUser
            // 
            labUser.AutoSize = true;
            labUser.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labUser.ForeColor = Color.MidnightBlue;
            labUser.Location = new Point(1106, 12);
            labUser.Name = "labUser";
            labUser.Size = new Size(119, 39);
            labUser.TabIndex = 1;
            labUser.Text = "Admin";
            // 
            // labCarRental
            // 
            labCarRental.AutoSize = true;
            labCarRental.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labCarRental.ForeColor = Color.MidnightBlue;
            labCarRental.Location = new Point(91, 9);
            labCarRental.Name = "labCarRental";
            labCarRental.Size = new Size(458, 34);
            labCarRental.TabIndex = 1;
            labCarRental.Text = "Car Rental Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pBoxCar
            // 
            pBoxCar.Image = (Image)resources.GetObject("pBoxCar.Image");
            pBoxCar.Location = new Point(0, 0);
            pBoxCar.Name = "pBoxCar";
            pBoxCar.Size = new Size(85, 53);
            pBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxCar.TabIndex = 1;
            pBoxCar.TabStop = false;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToDeleteRows = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.BackgroundColor = Color.White;
            dgvEmployee.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployee.Location = new Point(12, 363);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Crimson;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.RowTemplate.Height = 33;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(1299, 466);
            dgvEmployee.TabIndex = 44;
            dgvEmployee.SelectionChanged += dgvEmployee_SelectionChanged;
            // 
            // AdminPAge
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 841);
            Controls.Add(dgvEmployee);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(panel3);
            Controls.Add(labAvailable);
            Controls.Add(labModel);
            Controls.Add(labCarList);
            Controls.Add(txtPassword);
            Controls.Add(txtEmployee);
            Controls.Add(panel1);
            Name = "AdminPAge";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPage";
            Load += AdminPAge_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel3;
        private Panel panel6;
        private Label label3;
        private Label labAvailable;
        private Label labModel;
        private Label labCarList;
        private TextBox txtPassword;
        private TextBox txtEmployee;
        private Panel panel1;
        private Panel panel2;
        private Label labUser;
        private Label labCarRental;
        private PictureBox pictureBox1;
        private PictureBox pBoxCar;
        private PictureBox pictureBox2;
        private DataGridView dgvEmployee;
    }
}