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
    public partial class MDIEmployee : Form
    {
        public MDIEmployee()
        {
            InitializeComponent();
        }

        private void MDIEmployee_Load(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain car = new frmMain();
            car.MdiParent = this;
            car.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.MdiParent = this;
            customers.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void manageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.MdiParent = this;
            rent.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void manageToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Return return2 = new Return();
            return2.MdiParent = this;
            return2.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }
    }
}
