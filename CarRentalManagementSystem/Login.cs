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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\reald\\OneDrive\\Documents\\CarRentalManagementSystemDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void LoginFunction()
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            try
            {
                con.Open();

            
                string query = "SELECT EmpRole FROM EmployeeTb1 WHERE EmpName = @Username AND EmpPass = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", enteredUsername);
                    cmd.Parameters.AddWithValue("@Password", enteredPassword);

             
                    object result = cmd.ExecuteScalar();

                   
                    if (result != null)
                    {
                        string role = result.ToString();

                        
                        if (role == "Manager")
                        {
                           
                            MdiManager managerForm = new MdiManager();
                            managerForm.Show();
                            this.Close();
                        }
                        else if (role == "Staff")
                        {
                          
                            MDIEmployee staffForm = new MDIEmployee();

                            staffForm.Show();
                            this.Close();

                        }
                    }
                    else
                    {
                        
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginFunction();
        }
    }
}
