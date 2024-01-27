using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
     //   SqlConnection con = new SqlConnection(datasource);
        private void button1_Click(object sender, EventArgs e)
        {
            string user= username.Text.Trim();
            string pass= password.Text.Trim();

          // con.open();
           //string qurey = "Select * from TABLENAME where username=user and password=pass";
           // SqlDataAdapter apr = new SqlDataAdapter(query,con);
           // DataTable dt=new DataTable();
            //apr.Fill(dt);
           // con.close();
             //     if (dt.Rows.Count==1)
            {
                AdminPAge admin = new AdminPAge();
                admin.Show();
            }
        }
    }
}
