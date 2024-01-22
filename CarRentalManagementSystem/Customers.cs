using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^0[79]\d{8}$";
            if (!Regex.IsMatch(txtPhone.Text, pattern))
            {
                MessageBox.Show("The phone number must start with 0 and the second digit must be 7 or 9 and the total length is 10!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
