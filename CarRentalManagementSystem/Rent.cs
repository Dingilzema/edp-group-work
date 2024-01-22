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
    public partial class Rent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\reald\\OneDrive\\Documents\\CarRentalManagementSystemDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Rent()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double carFees;
            if ((double.TryParse(txtFees.Text, out double fees)))
            {
                carFees = fees;

            }
            else
            {
                MessageBox.Show("Fee must be a number!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            LoadRentData();
            LoadCustIdComboBox();
            DisplayCustNameFromComboBox();
            LoadRegNoComboBox();
            CalculateFees();



        }

        private DataTable custDataTable;


        private void LoadCustIdComboBox()
        {
            try
            {
                con.Open();


                string query = "SELECT CustId FROM CustomerTb1";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                DataTable custIdDataTable = new DataTable();


                adapter.Fill(custIdDataTable);


                cBoxCustId.Items.Clear();

                foreach (DataRow row in custIdDataTable.Rows)
                {
                    cBoxCustId.Items.Add(row["CustId"].ToString());
                }

                if (cBoxCustId.Items.Count > 0)
                {
                    cBoxCustId.SelectedIndex = 0;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }










        private void DisplayCustNameFromComboBox()
        {

            if (cBoxCustId.SelectedItem != null)
            {


                if (int.TryParse(cBoxCustId.SelectedItem.ToString(), out int selectedCustId))
                {
                    try
                    {
                        con.Close();

                        con.Open();

                        string query = "SELECT CustName FROM CustomerTb1 WHERE CustId = @CustId";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {

                            cmd.Parameters.AddWithValue("@CustId", selectedCustId);


                            object result = cmd.ExecuteScalar();


                            if (result != null)
                            {

                                txtCustName.Text = result.ToString();
                            }
                            else
                            {

                                MessageBox.Show("No customer found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (SqlException ex)
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

                    MessageBox.Show("Invalid selection. Please choose a valid customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadRegNoComboBox()
        {
            try
            {

                con.Open();


                string query = "SELECT RegNo FROM CarTb1 WHERE Available = 'Yes'";


                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                DataTable regNoDataTable = new DataTable();


                adapter.Fill(regNoDataTable);

                cBoxReg.Items.Clear();


                foreach (DataRow row in regNoDataTable.Rows)
                {
                    cBoxReg.Items.Add(row["RegNo"].ToString());
                }
                cBoxReg.SelectedIndex = -1;


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




        private void AddRentData()
        {

            if (cBoxReg.SelectedItem != null &&
                cBoxCustId.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(txtCustName.Text) &&
                datRent.Value != null &&
                datReturn.Value != null &&
                !string.IsNullOrWhiteSpace(txtFees.Text))
            {
                if (datRent.Value <= datReturn.Value)
                {
                    CalculateFees();

                    try
                    {
                        con.Open();



                        try
                        {

                            string updateQuery = "UPDATE CarTb1 SET Available = 'No' WHERE RegNo = @CarReg";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {

                                updateCmd.Parameters.AddWithValue("@CarReg", cBoxReg.SelectedItem.ToString());


                                updateCmd.ExecuteNonQuery();
                            }


                            string insertQuery = "INSERT INTO RentTb1 (CarReg, CustId, CustName, RentDate, ReturnDate, Fees) " +
                                                 "VALUES (@CarReg, @CustId, @CustName, @RentDate, @ReturnDate, @Fees)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                            {

                                cmd.Parameters.AddWithValue("@CarReg", cBoxReg.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@CustId", int.Parse(cBoxCustId.SelectedItem.ToString()));
                                cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                                cmd.Parameters.AddWithValue("@RentDate", datRent.Value);
                                cmd.Parameters.AddWithValue("@ReturnDate", datReturn.Value);
                                cmd.Parameters.AddWithValue("@Fees", float.Parse(txtFees.Text));


                                cmd.ExecuteNonQuery();
                            }



                            MessageBox.Show("Car rented successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            LoadRegNoComboBox();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Invalid date selection. Return date should be greater than rent date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields. Check the car regno values again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void LoadRentData()
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
                        double price = Convert.ToDouble(row["Fees"]);
                        row["Fees"] = Math.Round(price, 2);
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

        private void ClearForm()
        {

            cBoxReg.SelectedIndex = -1;
            cBoxCustId.SelectedIndex = -1;
            txtCustName.Clear();
            datRent.Value = DateTime.Today;
            datReturn.Value = DateTime.Today;
            txtFees.Clear();


        }





        private void cBoxCustId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            DisplayCustNameFromComboBox();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRentData();
            LoadRentData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }





        private void dgvRent_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvRent.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvRent.SelectedRows[0];


                if (selectedRow.Cells["CarReg"].Value != null)
                {

                    cBoxReg.SelectedItem = selectedRow.Cells["CarReg"].Value.ToString();
                }
                else
                {
                    cBoxReg.SelectedIndex = -1;
                }

                if (selectedRow.Cells["CustId"].Value != null)
                {
                    cBoxCustId.SelectedItem = selectedRow.Cells["CustId"].Value.ToString();
                }
                else
                {
                    cBoxCustId.SelectedIndex = -1;
                }

                txtCustName.Text = selectedRow.Cells["CustName"].Value?.ToString();

                if (selectedRow.Cells["RentDate"].Value != null)
                {
                    datRent.Value = Convert.ToDateTime(selectedRow.Cells["RentDate"].Value);
                }

                if (selectedRow.Cells["ReturnDate"].Value != null)
                {
                    datReturn.Value = Convert.ToDateTime(selectedRow.Cells["ReturnDate"].Value);
                }

                if (selectedRow.Cells["Fees"].Value != null)
                {
                    txtFees.Text = selectedRow.Cells["Fees"].Value.ToString();
                }
                else
                {
                    txtFees.Text = string.Empty;
                }
            }

        }






        private void DeleteSelectedRent()
        {
            if (dgvRent.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvRent.SelectedRows[0];


                if (selectedRow.Cells["RId"].Value != null && int.TryParse(selectedRow.Cells["RId"].Value.ToString(), out int rentId))
                {
                    try
                    {


                        con.Open();


                        string carRegQuery = "SELECT CarReg FROM RentTb1 WHERE RId = @RentId";

                        using (SqlCommand carRegCmd = new SqlCommand(carRegQuery, con))
                        {
                            carRegCmd.Parameters.AddWithValue("@RentId", rentId);
                            string carReg = carRegCmd.ExecuteScalar()?.ToString();

                            if (!string.IsNullOrEmpty(carReg))
                            {

                                string updateQuery = "UPDATE CarTb1 SET Available = 'Yes' WHERE RegNo = @CarReg";

                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                {

                                    updateCmd.Parameters.AddWithValue("@CarReg", carReg);


                                    updateCmd.ExecuteNonQuery();
                                }

                                string deleteQuery = "DELETE FROM RentTb1 WHERE RId = @RentId";


                                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                                {
                                    cmd.Parameters.AddWithValue("@RentId", rentId);


                                    int rowsAffected = cmd.ExecuteNonQuery();


                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Rent record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        con.Close();
                                        LoadRentData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error deleting the rent record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                con.Close();
                                LoadRegNoComboBox();
                            }
                            else
                            {
                                MessageBox.Show("Error retrieving CarReg for the selected rent record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a rent record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRent();
        }
        private void CalculateFees()
        {
            try
            {


                if (datRent.Value <= datReturn.Value)
                {

                    int daysDifference = (int)(datReturn.Value - datRent.Value).TotalDays;



                    if (cBoxReg.SelectedItem != null)
                    {
                        string selectedRegNo = cBoxReg.SelectedItem.ToString();


                        con.Open();


                        string query = "SELECT Price FROM CarTb1 WHERE RegNo = @RegNo ";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {

                            cmd.Parameters.AddWithValue("@RegNo", selectedRegNo);


                            object result = cmd.ExecuteScalar();



                            if (result != null && double.TryParse(result.ToString(), out double carPrice))
                            {

                                double fees = daysDifference * carPrice;


                                txtFees.Text = fees.ToString("0.00");
                            }
                            else
                            {
                                MessageBox.Show("Error retrieving car price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }




                    else
                    {
                        txtFees.Text = String.Empty;
                    }
                }
                else
                {
                    txtFees.Text = "0.00".ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void datRent_ValueChanged(object sender, EventArgs e)
        {
            CalculateFees();

        }

        private void cBoxReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFees();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            Return return2 = new Return();
            return2.Show();
            this.Close();
        }
    }
}
