namespace CarRentalManagementSystem
{
    partial class MDIEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIEmployee));
            menuStrip1 = new MenuStrip();
            carToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem1 = new ToolStripMenuItem();
            rentToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem2 = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { carToolStripMenuItem, customerToolStripMenuItem, rentToolStripMenuItem, returnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1343, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // carToolStripMenuItem
            // 
            carToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem });
            carToolStripMenuItem.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            carToolStripMenuItem.ForeColor = Color.Crimson;
            carToolStripMenuItem.Image = (Image)resources.GetObject("carToolStripMenuItem.Image");
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(105, 38);
            carToolStripMenuItem.Text = "Car";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.ForeColor = Color.Crimson;
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(237, 42);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem1 });
            customerToolStripMenuItem.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customerToolStripMenuItem.ForeColor = Color.Crimson;
            customerToolStripMenuItem.Image = (Image)resources.GetObject("customerToolStripMenuItem.Image");
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(186, 38);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // manageToolStripMenuItem1
            // 
            manageToolStripMenuItem1.ForeColor = Color.Crimson;
            manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            manageToolStripMenuItem1.Size = new Size(237, 42);
            manageToolStripMenuItem1.Text = "Manage";
            manageToolStripMenuItem1.Click += manageToolStripMenuItem1_Click;
            // 
            // rentToolStripMenuItem
            // 
            rentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem2 });
            rentToolStripMenuItem.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rentToolStripMenuItem.ForeColor = Color.Crimson;
            rentToolStripMenuItem.Image = (Image)resources.GetObject("rentToolStripMenuItem.Image");
            rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            rentToolStripMenuItem.Size = new Size(117, 38);
            rentToolStripMenuItem.Text = "Rent";
            // 
            // manageToolStripMenuItem2
            // 
            manageToolStripMenuItem2.ForeColor = Color.Crimson;
            manageToolStripMenuItem2.Name = "manageToolStripMenuItem2";
            manageToolStripMenuItem2.Size = new Size(237, 42);
            manageToolStripMenuItem2.Text = "Manage";
            manageToolStripMenuItem2.Click += manageToolStripMenuItem2_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem3 });
            returnToolStripMenuItem.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            returnToolStripMenuItem.ForeColor = Color.Crimson;
            returnToolStripMenuItem.Image = (Image)resources.GetObject("returnToolStripMenuItem.Image");
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(142, 38);
            returnToolStripMenuItem.Text = "Return";
            // 
            // manageToolStripMenuItem3
            // 
            manageToolStripMenuItem3.ForeColor = Color.Crimson;
            manageToolStripMenuItem3.Name = "manageToolStripMenuItem3";
            manageToolStripMenuItem3.Size = new Size(237, 42);
            manageToolStripMenuItem3.Text = "Manage";
            manageToolStripMenuItem3.Click += manageToolStripMenuItem3_Click;
            // 
            // MDIEmployee
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1343, 864);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1365, 920);
            MinimumSize = new Size(1365, 920);
            Name = "MDIEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += MDIEmployee_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem carToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem1;
        private ToolStripMenuItem rentToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem2;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem3;
    }
}