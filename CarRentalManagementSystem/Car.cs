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
    public partial class frmMain : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\reald\\OneDrive\\Documents\\CarRentalManagementSystemDb.mdf;Integrated Security=True;Connect Timeout=30");

        public frmMain()
        {

            InitializeComponent();

        }
        float carPrice;

        private void button1_Click(object sender, EventArgs e)
        {

            if (!AreFieldsEmpty())
            {
                if ((float.TryParse(txtPrice.Text, out float price)))
                {
                    carPrice = (float)Math.Round(price, 2);

                    InsertCarData();
                    ClearFields();
                    LoadCarData();

                }
                else
                {
                    MessageBox.Show("Price must be a number!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must fill every value!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCarData();
        }
        private bool AreFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(txtRegNo.Text) ||
                   cBoxBrand.SelectedItem == null ||
                   string.IsNullOrWhiteSpace(txtModel.Text) ||
                   string.IsNullOrWhiteSpace(txtPrice.Text) ||
                   string.IsNullOrWhiteSpace(txtColor.Text) ||
                   cBoxAvailable.SelectedItem == null;
        }
        private void InsertCarData()
        {
            try
            {
                con.Open();

                // Prepare the SQL query
                string query = "INSERT INTO CarTb1 (RegNo, Brand, Model, Price, Color, Available) VALUES (@RegNo, @Brand, @Model, @Price, @Color, @Available)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Set parameters
                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                    cmd.Parameters.AddWithValue("@Brand", cBoxBrand.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);


                    cmd.Parameters.AddWithValue("@Price", carPrice);


                    cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@Available", cBoxAvailable.SelectedItem.ToString());

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Car data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();


        }
        private void ClearFields()
        {
            txtRegNo.Text = string.Empty;
            cBoxBrand.SelectedIndex = -1;
            txtModel.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtColor.Text = string.Empty;
            cBoxAvailable.SelectedIndex = -1;
        }
        private void LoadCarData()
        {
            try
            {
                con.Open();


                string query = "SELECT * FROM CarTb1";


                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                DataTable carDataTable = new DataTable();

                adapter.Fill(carDataTable);


                foreach (DataRow row in carDataTable.Rows)
                {
                    if (row["Price"] != DBNull.Value)
                    {
                        double price = Convert.ToDouble(row["Price"]);
                        row["Price"] = Math.Round(price, 2);
                    }
                }


                dgvCar.DataSource = carDataTable;
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

        private void DeleteSelectedCar()
        {
            if (dgvCar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCar.SelectedRows[0];

                if (selectedRow.Cells["CId"].Value != null && int.TryParse(selectedRow.Cells["CId"].Value.ToString(), out int carId))
                {
                    try
                    {
                        con.Open();

                        if (selectedRow.Cells["Available"].Value != null && selectedRow.Cells["Available"].Value.ToString().Equals("No"))
                        {
                            MessageBox.Show("This car cannot be deleted as it is marked as not available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string deleteQuery = "DELETE FROM CarTb1 WHERE CId = @CarId";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@CarId", carId);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Car deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con.Close();
                                    LoadCarData();
                                }
                                else
                                {
                                    MessageBox.Show("Error deleting the car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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
                MessageBox.Show("Please select a car to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedCar();
        }





        private void dgvCar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCar.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvCar.SelectedRows[0];


                txtRegNo.Text = selectedRow.Cells["RegNo"].Value.ToString();
                cBoxBrand.SelectedItem = selectedRow.Cells["Brand"].Value.ToString();
                txtModel.Text = selectedRow.Cells["Model"].Value.ToString();

                double carPrice;
                if (double.TryParse(selectedRow.Cells["Price"].Value.ToString(), out carPrice))
                {
                    txtPrice.Text = carPrice.ToString();
                }
                txtColor.Text = selectedRow.Cells["Color"].Value.ToString();
                cBoxAvailable.SelectedItem = selectedRow.Cells["Available"].Value.ToString();
            }
        }

        private void dgvCar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCar.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvCar.SelectedRows[0];


                txtRegNo.Text = selectedRow.Cells["RegNo"].Value.ToString();
                cBoxBrand.SelectedItem = selectedRow.Cells["Brand"].Value.ToString();
                txtModel.Text = selectedRow.Cells["Model"].Value.ToString();

                double carPrice;
                if (double.TryParse(selectedRow.Cells["Price"].Value.ToString(), out carPrice))
                {
                    txtPrice.Text = carPrice.ToString();
                }
                txtColor.Text = selectedRow.Cells["Color"].Value.ToString();
                cBoxAvailable.SelectedItem = selectedRow.Cells["Available"].Value.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (dgvCar.SelectedRows.Count > 0)
            {

                try
                {
                    con.Open();


                    string query = "UPDATE CarTb1 SET RegNo = @RegNo, Brand = @Brand, Model = @Model, Price = @Price, Color = @Color, Available = @Available WHERE CId = @CId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                        cmd.Parameters.AddWithValue("@Brand", cBoxBrand.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);

                        if (decimal.TryParse(txtPrice.Text, out decimal carPrice))
                        {
                            cmd.Parameters.AddWithValue("@Price", carPrice);
                        }
                        cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                        cmd.Parameters.AddWithValue("@Available", cBoxAvailable.SelectedItem?.ToString());

                        cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(dgvCar.SelectedRows[0].Cells["CId"].Value));


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Car data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        LoadCarData();
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
            else
            {
                MessageBox.Show("Please select a car from the data grid view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void label6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Return return2 = new Return();
            return2.Show();
            this.Close();
        }
    }

}



