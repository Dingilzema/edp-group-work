namespace CarRentalManagementSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            labUser = new Label();
            labCarRental = new Label();
            pictureBox1 = new PictureBox();
            pBoxCar = new PictureBox();
            txtRegNo = new TextBox();
            labReg = new Label();
            txtModel = new TextBox();
            labModel = new Label();
            txtColor = new TextBox();
            labColor = new Label();
            cBoxBrand = new ComboBox();
            labBrand = new Label();
            labAvailable = new Label();
            cBoxAvailable = new ComboBox();
            txtPrice = new TextBox();
            labPrice = new Label();
            labCarList = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            dgvCar = new DataGridView();
            btnClear = new Button();
            button3 = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCar).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
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
            labUser.Location = new Point(1168, 6);
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
            pictureBox1.Location = new Point(1099, -3);
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
            // txtRegNo
            // 
            txtRegNo.BackColor = Color.White;
            txtRegNo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegNo.ForeColor = Color.Crimson;
            txtRegNo.Location = new Point(59, 188);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(360, 37);
            txtRegNo.TabIndex = 0;
            // 
            // labReg
            // 
            labReg.AutoSize = true;
            labReg.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labReg.ForeColor = Color.Crimson;
            labReg.Location = new Point(59, 138);
            labReg.Name = "labReg";
            labReg.Size = new Size(186, 34);
            labReg.TabIndex = 1;
            labReg.Text = "Reg Number";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.White;
            txtModel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModel.ForeColor = Color.Crimson;
            txtModel.Location = new Point(978, 188);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(316, 37);
            txtModel.TabIndex = 2;
            // 
            // labModel
            // 
            labModel.AutoSize = true;
            labModel.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labModel.ForeColor = Color.Crimson;
            labModel.Location = new Point(978, 138);
            labModel.Name = "labModel";
            labModel.Size = new Size(101, 34);
            labModel.TabIndex = 1;
            labModel.Text = "Model";
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.White;
            txtColor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtColor.ForeColor = Color.Crimson;
            txtColor.Location = new Point(544, 292);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(378, 37);
            txtColor.TabIndex = 4;
            // 
            // labColor
            // 
            labColor.AutoSize = true;
            labColor.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labColor.ForeColor = Color.Crimson;
            labColor.Location = new Point(544, 242);
            labColor.Name = "labColor";
            labColor.Size = new Size(88, 34);
            labColor.TabIndex = 1;
            labColor.Text = "Color";
            // 
            // cBoxBrand
            // 
            cBoxBrand.DropDownHeight = 300;
            cBoxBrand.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxBrand.FormattingEnabled = true;
            cBoxBrand.IntegralHeight = false;
            cBoxBrand.Items.AddRange(new object[] { "Audi", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Ford", "GM", "GEM", "GMC", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Lotus", "Mazda", "Mercedes-Benz", "Mercury", "Mitsubishi", "Nissan", "Oldsmobile", "Peugeot", "Pontiac", "Porsche", "Regal", "Saab", "Saturn", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo" });
            cBoxBrand.Location = new Point(544, 188);
            cBoxBrand.MaxDropDownItems = 5;
            cBoxBrand.Name = "cBoxBrand";
            cBoxBrand.Size = new Size(378, 38);
            cBoxBrand.TabIndex = 1;
            // 
            // labBrand
            // 
            labBrand.AutoSize = true;
            labBrand.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labBrand.ForeColor = Color.Crimson;
            labBrand.Location = new Point(544, 138);
            labBrand.Name = "labBrand";
            labBrand.Size = new Size(94, 34);
            labBrand.TabIndex = 1;
            labBrand.Text = "Brand";
            // 
            // labAvailable
            // 
            labAvailable.AutoSize = true;
            labAvailable.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labAvailable.ForeColor = Color.Crimson;
            labAvailable.Location = new Point(978, 241);
            labAvailable.Name = "labAvailable";
            labAvailable.Size = new Size(147, 34);
            labAvailable.TabIndex = 1;
            labAvailable.Text = "Available";
            // 
            // cBoxAvailable
            // 
            cBoxAvailable.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxAvailable.FormattingEnabled = true;
            cBoxAvailable.Items.AddRange(new object[] { "Yes", "No" });
            cBoxAvailable.Location = new Point(978, 291);
            cBoxAvailable.Name = "cBoxAvailable";
            cBoxAvailable.Size = new Size(316, 38);
            cBoxAvailable.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.Crimson;
            txtPrice.Location = new Point(59, 282);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(360, 37);
            txtPrice.TabIndex = 3;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // labPrice
            // 
            labPrice.AutoSize = true;
            labPrice.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labPrice.ForeColor = Color.Crimson;
            labPrice.Location = new Point(59, 232);
            labPrice.Name = "labPrice";
            labPrice.Size = new Size(83, 34);
            labPrice.TabIndex = 1;
            labPrice.Text = "Price";
            // 
            // labCarList
            // 
            labCarList.AutoSize = true;
            labCarList.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labCarList.ForeColor = Color.Crimson;
            labCarList.Location = new Point(544, 424);
            labCarList.Name = "labCarList";
            labCarList.Size = new Size(144, 43);
            labCarList.TabIndex = 1;
            labCarList.Text = "Car List";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
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
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Location = new Point(201, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(125, 5);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(910, 6);
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
            label3.Location = new Point(704, 9);
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
            label2.Location = new Point(440, 6);
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
            label1.Location = new Point(250, 3);
            label1.Name = "label1";
            label1.Size = new Size(76, 34);
            label1.TabIndex = 1;
            label1.Text = "Cars";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(861, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(655, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(392, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(201, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // dgvCar
            // 
            dgvCar.AllowUserToAddRows = false;
            dgvCar.AllowUserToDeleteRows = false;
            dgvCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCar.BackgroundColor = Color.White;
            dgvCar.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCar.Location = new Point(12, 470);
            dgvCar.MultiSelect = false;
            dgvCar.Name = "dgvCar";
            dgvCar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Crimson;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCar.RowHeadersWidth = 62;
            dgvCar.RowTemplate.Height = 33;
            dgvCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCar.Size = new Size(1299, 359);
            dgvCar.TabIndex = 4;
            dgvCar.CellMouseClick += dgvCar_CellMouseClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Navy;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(792, 353);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 43);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(636, 353);
            button3.Name = "button3";
            button3.Size = new Size(135, 43);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Navy;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(504, 353);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 43);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(361, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 43);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // frmMain
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1323, 841);
            Controls.Add(btnClear);
            Controls.Add(button3);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCar);
            Controls.Add(panel3);
            Controls.Add(cBoxAvailable);
            Controls.Add(cBoxBrand);
            Controls.Add(labColor);
            Controls.Add(labPrice);
            Controls.Add(labAvailable);
            Controls.Add(labModel);
            Controls.Add(labBrand);
            Controls.Add(labCarList);
            Controls.Add(labReg);
            Controls.Add(txtPrice);
            Controls.Add(txtColor);
            Controls.Add(txtModel);
            Controls.Add(txtRegNo);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pBoxCar;
        private Label labCarRental;
        private PictureBox pictureBox1;
        private Label labUser;
        private TextBox txtRegNo;
        private Label labReg;
        private TextBox txtModel;
        private Label labModel;
        private TextBox txtColor;
        private Label labColor;
        private ComboBox cBoxBrand;
        private Label labBrand;
        private Label labAvailable;
        private ComboBox cBoxAvailable;
        private TextBox txtPrice;
        private Label labPrice;
        private Panel panel2;
        private Label labCarList;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private DataGridView dgvCar;
        private Button btnClear;
        private Button button3;
        private Button btnEdit;
        private Button btnAdd;
    }
}