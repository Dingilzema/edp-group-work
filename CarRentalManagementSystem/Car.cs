using System;
using
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string regNumber = Reg_Number.Text;
            string brand = Brand.SelectedItem?.ToString() ?? "";
            string model = Model.Text;
            decimal price = Convert.ToDecimal(Price.Text);
            string color = System.Drawing.Color.Text;
            string available = Available.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO CarTable (Reg_Number, Brand, Model, Price, Color, Available) " +
                               "VALUES (@Reg_Number, @Brand, @Model, @Price, @Color, @Available)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Reg_Number", regNumber);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Color", color);
                    cmd.Parameters.AddWithValue("@Available", available);

                    cmd.ExecuteNonQuery();
                }
            }

            LoadData()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string regNumber = Reg_Number.Text;
            string brand = Brand.SelectedItem?.ToString() ?? "";
            string model = Model.Text;
            decimal price = Convert.ToDecimal(Price.Text);
            string color = Color.Text;
            string available = Avaiable.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE CarTable SET Brand = @Brand, Model = @Model, " +
                               "Price = @Price, Color = @Color, Available = @Available " +
                               "WHERE Reg_Number = @Reg_Number";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Reg_Number", regNumber);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Color", color);
                    cmd.Parameters.AddWithValue("@Available", available);

                    cmd.ExecuteNonQuery();
                }
            }

            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string regNumber = Reg_Number.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM CarTable WHERE Reg_Number = @Reg_Number";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Reg_Number", regNumber);
                    cmd.ExecuteNonQuery();
                }
            }

            ClearFields();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reg_Number.Clear();
            Brand.SelectedIndex = -1;
            Model.Clear();
            Price.Clear();
            Color.Clear();
            Available.SelectedIndex = -1;
        }
        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM CarTable", connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
        private void ClearFields()
        {
            Reg_Number.Clear();
            Brand.SelectedIndex = -1;
            Model.Clear();
            Price.Clear();
            Color.Clear();
            Available.SelectedIndex = -1;
        }
    }
}
