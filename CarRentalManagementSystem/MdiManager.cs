using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class MdiManager : Form
    {
        public MdiManager()
        {
            InitializeComponent();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPAge adminPage = new AdminPAge();
            adminPage.MdiParent = this;
            adminPage.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MdiManager_Load(object sender, EventArgs e)
        {

        }
    }
}
