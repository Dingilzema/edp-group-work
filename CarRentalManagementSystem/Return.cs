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
    public partial class Return : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\reald\\OneDrive\\Documents\\CarRentalManagementSystemDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Return()
        {

            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            LoadRentDataIntoDataGridView();
            LoadReturnData();



        }
        private void LoadRentDataIntoDataGridView()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM RentTb1";


                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                DataTable rentDataTable = new DataTable();


                adapter.Fill(rentDataTable);

                foreach (DataRow row in rentDataTable.Rows)
                {
                    if (row["Fees"] != DBNull.Value)
                    {
                        row["Fees"] = Math.Round(Convert.ToDouble(row["Fees"]), 2);
                    }
                }


                dgvRent.DataSource = rentDataTable;
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



        private void dgvRent_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvRent.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvRent.SelectedRows[0];


                txtReg.Text = selectedRow.Cells["CarReg"].Value?.ToString();
                txtCustName.Text = selectedRow.Cells["CustName"].Value?.ToString();


                if (DateTime.TryParse(selectedRow.Cells["ReturnDate"].Value?.ToString(), out DateTime returnDate))
                {

                    txtReturn.Text = returnDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    txtReturn.Text = string.Empty;
                }
            }
            CalculateAndDisplayFee();


        }


        private void CalculateAndDisplayFee()
        {
            if (dgvRent.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvRent.SelectedRows[0];


                if (selectedRow.Cells["ReturnDate"].Value != null &&
                    DateTime.TryParse(selectedRow.Cells["ReturnDate"].Value.ToString(), out DateTime returnDate))
                {

                    TimeSpan delay = DateTime.Now.Date - returnDate.Date;


                    if (delay.TotalDays >= 1)
                    {

                        decimal fine = 150 * (decimal)delay.TotalDays;


                        txtFine.Text = fine.ToString("0.00");
                        txtDelay.Text = delay.Days.ToString();
                    }
                    else
                    {
                        txtFine.Text = "No Fee";
                        txtDelay.Text = "No Delay";
                    }
                }
            }
        }



        private void AddReturn()
        {
            if (dgvRent.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvRent.SelectedRows[0];


                if (selectedRow.Cells["RId"].Value != null && int.TryParse(selectedRow.Cells["RId"].Value.ToString(), out int rentId))
                {

                    string carReg = selectedRow.Cells["CarReg"].Value.ToString();
                    string custName = selectedRow.Cells["CustName"].Value.ToString();
                    string returnDate = txtReturn.Text;


                    string delay = txtDelay.Text;
                    string fine = txtFine.Text;



                    UpdateCarAvailability(carReg);

                    AddToReturnTable(carReg, custName, returnDate, delay, fine);


                    DeleteSelectedRent(rentId);


                    LoadRentDataIntoDataGridView();
                    LoadReturnData();
                }
            }
        }

        private void UpdateCarAvailability(string carReg)
        {
            try
            {
                con.Open();


                string updateQuery = "UPDATE CarTb1 SET Available = 'Yes' WHERE RegNo = @CarReg";

                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@CarReg", carReg);


                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating car availability: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void AddToReturnTable(string carReg, string custName, string returnDate, string delay, string fee)
        {
            try
            {
                con.Open();


                string insertQuery = "INSERT INTO ReturnTb1 (CarReg, CustName, ReturnDate, Delay, Fine) " +
                                     "VALUES (@CarReg, @CustName, @ReturnDate, @Delay, @Fine)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {

                    cmd.Parameters.AddWithValue("@CarReg", carReg);
                    cmd.Parameters.AddWithValue("@CustName", custName);
                    cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                    cmd.Parameters.AddWithValue("@Delay", delay);
                    cmd.Parameters.AddWithValue("@Fine", fee);


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to ReturnTb1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void DeleteSelectedRent(int rentId)
        {
            try
            {
                con.Open();


                string deleteQuery = "DELETE FROM RentTb1 WHERE RId = @RentId";


                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@RentId", rentId);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting rent record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadReturnData()
        {

            try
            {
                con.Open();


                string query = "SELECT * FROM ReturnTb1";


                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                DataTable returnDataTable = new DataTable();


                adapter.Fill(returnDataTable);

                dgvReturn.DataSource = returnDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ReturnTb1 data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReturn();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmMain car = new frmMain();
            car.Show();
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
    }

}
