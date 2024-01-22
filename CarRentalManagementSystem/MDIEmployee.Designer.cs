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
            menuStrip1 = new MenuStrip();
            carToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            rentToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem1 = new ToolStripMenuItem();
            manageToolStripMenuItem2 = new ToolStripMenuItem();
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
            menuStrip1.Size = new Size(1195, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // carToolStripMenuItem
            // 
            carToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem });
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(54, 29);
            carToolStripMenuItem.Text = "Car";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem1 });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(105, 29);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // rentToolStripMenuItem
            // 
            rentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem2 });
            rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            rentToolStripMenuItem.Size = new Size(63, 29);
            rentToolStripMenuItem.Text = "Rent";
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem3 });
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(79, 29);
            returnToolStripMenuItem.Text = "Return";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(270, 34);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // manageToolStripMenuItem1
            // 
            manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            manageToolStripMenuItem1.Size = new Size(270, 34);
            manageToolStripMenuItem1.Text = "Manage";
            // 
            // manageToolStripMenuItem2
            // 
            manageToolStripMenuItem2.Name = "manageToolStripMenuItem2";
            manageToolStripMenuItem2.Size = new Size(270, 34);
            manageToolStripMenuItem2.Text = "Manage";
            // 
            // manageToolStripMenuItem3
            // 
            manageToolStripMenuItem3.Name = "manageToolStripMenuItem3";
            manageToolStripMenuItem3.Size = new Size(270, 34);
            manageToolStripMenuItem3.Text = "Manage";
            // 
            // MDIEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1195, 753);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
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