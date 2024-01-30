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
    public partial class AdminPAge : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\reald\\OneDrive\\Documents\\CarRentalManagementSystemDb.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminPAge()
        {
            InitializeComponent();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee();

        }

        //Employee adding function
        private void AddEmployee()
        {


            if (string.IsNullOrWhiteSpace(txtEmployee.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in both Employee Name and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newEmployeeName = txtEmployee.Text;
            string newPassword = txtPassword.Text;

            try
            {

                con.Open();


                string insertQuery = "INSERT INTO EmployeeTb1 (EmpName, EmpPass, EmpRole) VALUES (@EmpName, @EmpPass, @EmpRole)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {

                    cmd.Parameters.AddWithValue("@EmpName", newEmployeeName);
                    cmd.Parameters.AddWithValue("@EmpPass", newPassword);
                    cmd.Parameters.AddWithValue("@EmpRole", "Staff");


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                con.Close();
                LoadEmployeeData();
                ClearEmployeeTextBoxes();
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

        private void LoadEmployeeData()
        {
            try
            {
                con.Open();


                string query = "SELECT * FROM EmployeeTb1 WHERE EmpRole = 'Staff'";


                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                DataTable employeeDataTable = new DataTable();


                adapter.Fill(employeeDataTable);


                dgvEmployee.DataSource = employeeDataTable;
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

        private void AdminPAge_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }



        private void PopulateEmployeeTextBoxes()
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];


                txtEmployee.Text = selectedRow.Cells["EmpName"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["EmpPass"].Value.ToString();
            }
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            PopulateEmployeeTextBoxes();
        }

        private void ClearEmployeeTextBoxes()
        {
            txtEmployee.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEmployeeTextBoxes();
        }


        private void UpdateEmployee()
        {

            if (dgvEmployee.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];


                if (selectedRow.Cells["EmpId"].Value != null && int.TryParse(selectedRow.Cells["EmpId"].Value.ToString(), out int empId))
                {
                    try
                    {

                        con.Open();


                        string updateQuery = "UPDATE EmployeeTb1 SET EmpName = @EmpName, EmpPass = @EmpPass WHERE EmpId = @EmpId";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {

                            cmd.Parameters.AddWithValue("@EmpName", txtEmployee.Text);
                            cmd.Parameters.AddWithValue("@EmpPass", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@EmpId", empId);

                            int rowsAffected = cmd.ExecuteNonQuery();


                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                con.Close();
                                LoadEmployeeData();
                            }
                            else
                            {
                                MessageBox.Show("Error updating employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            else
            {
                MessageBox.Show("Please select an employee record from the data grid view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        private void DeleteEmployee()
        {

            if (dgvEmployee.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];


                if (selectedRow.Cells["EmpId"].Value != null && int.TryParse(selectedRow.Cells["EmpId"].Value.ToString(), out int empId))
                {
                    try
                    {

                        con.Open();


                        string deleteQuery = "DELETE FROM EmployeeTb1 WHERE EmpId = @EmpId";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {

                            cmd.Parameters.AddWithValue("@EmpId", empId);


                            int rowsAffected = cmd.ExecuteNonQuery();


                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                con.Close();
                                LoadEmployeeData();
                            }
                            else
                            {
                                MessageBox.Show("Error deleting employee record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            else
            {
                MessageBox.Show("Please select an employee record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
