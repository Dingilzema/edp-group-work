namespace CarRentalManagementSystem
{
    partial class Rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            panel6 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            dgvRent = new DataGridView();
            panel2 = new Panel();
            labUser = new Label();
            labCarRental = new Label();
            pictureBox1 = new PictureBox();
            pBoxCar = new PictureBox();
            panel3 = new Panel();
            cBoxCustId = new ComboBox();
            labColor = new Label();
            labPrice = new Label();
            labAvailable = new Label();
            labModel = new Label();
            labBrand = new Label();
            labCarList = new Label();
            labReg = new Label();
            txtCustName = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            label5 = new Label();
            cBoxReg = new ComboBox();
            txtFees = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            datRent = new DateTimePicker();
            datReturn = new DateTimePicker();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(737, 46);
            panel6.Name = "panel6";
            panel6.Size = new Size(125, 5);
            panel6.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(1143, 9);
            label4.Name = "label4";
            label4.Size = new Size(100, 34);
            label4.TabIndex = 1;
            label4.Text = "Return";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(786, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 34);
            label3.TabIndex = 1;
            label3.Text = "Rent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(413, 3);
            label2.Name = "label2";
            label2.Size = new Size(157, 34);
            label2.TabIndex = 1;
            label2.Text = "Customers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(150, 3);
            label1.Name = "label1";
            label1.Size = new Size(76, 34);
            label1.TabIndex = 1;
            label1.Text = "Cars";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1094, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(737, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(366, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(101, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // dgvRent
            // 
            dgvRent.BackgroundColor = Color.White;
            dgvRent.BorderStyle = BorderStyle.None;
            dgvRent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRent.Location = new Point(36, 448);
            dgvRent.Name = "dgvRent";
            dgvRent.RowHeadersWidth = 62;
            dgvRent.RowTemplate.Height = 33;
            dgvRent.Size = new Size(1264, 360);
            dgvRent.TabIndex = 20;
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
            labUser.ForeColor = Color.Crimson;
            labUser.Location = new Point(1163, 9);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 39);
            labUser.TabIndex = 1;
            labUser.Text = "Staff";
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
            pictureBox1.Location = new Point(1094, 0);
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
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(1323, 72);
            panel3.TabIndex = 19;
            // 
            // cBoxCustId
            // 
            cBoxCustId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxCustId.FormattingEnabled = true;
            cBoxCustId.Location = new Point(497, 194);
            cBoxCustId.Name = "cBoxCustId";
            cBoxCustId.Size = new Size(378, 38);
            cBoxCustId.TabIndex = 18;
            // 
            // labColor
            // 
            labColor.AutoSize = true;
            labColor.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labColor.ForeColor = Color.Crimson;
            labColor.Location = new Point(497, 248);
            labColor.Name = "labColor";
            labColor.Size = new Size(178, 34);
            labColor.TabIndex = 6;
            labColor.Text = "Return Date";
            // 
            // labPrice
            // 
            labPrice.AutoSize = true;
            labPrice.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labPrice.ForeColor = Color.Crimson;
            labPrice.Location = new Point(59, 238);
            labPrice.Name = "labPrice";
            labPrice.Size = new Size(153, 34);
            labPrice.TabIndex = 7;
            labPrice.Text = "Rent Date";
            // 
            // labAvailable
            // 
            labAvailable.AutoSize = true;
            labAvailable.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labAvailable.ForeColor = Color.Crimson;
            labAvailable.Location = new Point(906, 247);
            labAvailable.Name = "labAvailable";
            labAvailable.Size = new Size(76, 34);
            labAvailable.TabIndex = 8;
            labAvailable.Text = "Fees";
            // 
            // labModel
            // 
            labModel.AutoSize = true;
            labModel.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labModel.ForeColor = Color.Crimson;
            labModel.Location = new Point(906, 144);
            labModel.Name = "labModel";
            labModel.Size = new Size(238, 34);
            labModel.TabIndex = 9;
            labModel.Text = "Customer Name";
            // 
            // labBrand
            // 
            labBrand.AutoSize = true;
            labBrand.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labBrand.ForeColor = Color.Crimson;
            labBrand.Location = new Point(497, 144);
            labBrand.Name = "labBrand";
            labBrand.Size = new Size(181, 34);
            labBrand.TabIndex = 10;
            labBrand.Text = "Customer ID";
            // 
            // labCarList
            // 
            labCarList.AutoSize = true;
            labCarList.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labCarList.ForeColor = Color.Crimson;
            labCarList.Location = new Point(528, 402);
            labCarList.Name = "labCarList";
            labCarList.Size = new Size(191, 43);
            labCarList.TabIndex = 11;
            labCarList.Text = "Rental List";
            // 
            // labReg
            // 
            labReg.AutoSize = true;
            labReg.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labReg.ForeColor = Color.Crimson;
            labReg.Location = new Point(59, 144);
            labReg.Name = "labReg";
            labReg.Size = new Size(186, 34);
            labReg.TabIndex = 12;
            labReg.Text = "Reg Number";
            // 
            // txtCustName
            // 
            txtCustName.BackColor = Color.White;
            txtCustName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustName.ForeColor = Color.Crimson;
            txtCustName.Location = new Point(906, 194);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(377, 37);
            txtCustName.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labUser);
            panel1.Controls.Add(labCarRental);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pBoxCar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 53);
            panel1.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(1256, 0);
            label9.Name = "label9";
            label9.Size = new Size(27, 34);
            label9.TabIndex = 30;
            label9.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(1289, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 34);
            label5.TabIndex = 28;
            label5.Text = "X";
            // 
            // cBoxReg
            // 
            cBoxReg.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxReg.FormattingEnabled = true;
            cBoxReg.Location = new Point(59, 194);
            cBoxReg.Name = "cBoxReg";
            cBoxReg.Size = new Size(390, 38);
            cBoxReg.TabIndex = 18;
            // 
            // txtFees
            // 
            txtFees.BackColor = Color.White;
            txtFees.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFees.ForeColor = Color.Crimson;
            txtFees.Location = new Point(906, 297);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(377, 37);
            txtFees.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Navy;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(645, 346);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 43);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(508, 346);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 43);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // datRent
            // 
            datRent.CustomFormat = "dd MMMM yyyy";
            datRent.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datRent.Format = DateTimePickerFormat.Custom;
            datRent.Location = new Point(59, 297);
            datRent.Name = "datRent";
            datRent.Size = new Size(390, 37);
            datRent.TabIndex = 25;
            // 
            // datReturn
            // 
            datReturn.CustomFormat = "dd MMMM yyyy";
            datReturn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datReturn.Format = DateTimePickerFormat.Custom;
            datReturn.Location = new Point(497, 293);
            datReturn.Name = "datReturn";
            datReturn.Size = new Size(378, 37);
            datReturn.TabIndex = 25;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Navy;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(810, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 43);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // Rent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 841);
            Controls.Add(datReturn);
            Controls.Add(datRent);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvRent);
            Controls.Add(panel3);
            Controls.Add(cBoxReg);
            Controls.Add(cBoxCustId);
            Controls.Add(labColor);
            Controls.Add(labPrice);
            Controls.Add(labAvailable);
            Controls.Add(labModel);
            Controls.Add(labBrand);
            Controls.Add(labCarList);
            Controls.Add(labReg);
            Controls.Add(txtFees);
            Controls.Add(txtCustName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent";
            Load += Rent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private DataGridView dgvRent;
        private Panel panel2;
        private Label labUser;
        private Label labCarRental;
        private PictureBox pictureBox1;
        private PictureBox pBoxCar;
        private Panel panel3;
        private ComboBox cBoxCustId;
        private Label labColor;
        private Label labPrice;
        private Label labAvailable;
        private Label labModel;
        private Label labBrand;
        private Label labCarList;
        private Label labReg;
        private TextBox txtCustName;
        private Panel panel1;
        private ComboBox cBoxReg;
        private TextBox txtFees;
        private Button btnDelete;
        private Button btnAdd;
        private DateTimePicker datRent;
        private DateTimePicker datReturn;
        private Label label5;
        private Label label9;
        private Button btnClear;
    }
}