namespace CarRentalManagementSystem
{
    partial class MdiManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiManager));
            menuStrip1 = new MenuStrip();
            staffToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { staffToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1343, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem });
            staffToolStripMenuItem.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            staffToolStripMenuItem.ForeColor = Color.Crimson;
            staffToolStripMenuItem.Image = (Image)resources.GetObject("staffToolStripMenuItem.Image");
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(116, 38);
            staffToolStripMenuItem.Text = "Staff";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.ForeColor = Color.Crimson;
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(237, 42);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // MdiManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 864);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1365, 920);
            MinimumSize = new Size(1365, 920);
            Name = "MdiManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MdiManager";
            Load += MdiManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
    }
}