using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace CarRentalManagementSystem
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
         //SqlConnection con = new SqlConnection(datasource);
        private void populate()
        {
            con.open();
            //string query = "Select * from RENTTABLE";
             SqlDataAdapter apr = new SqlDataAdapter(query,con);
             DataTable dt=new DataTable();
            apr.Fill(dt);
            BindingSource bindingSource = new BindingSource();
             bindingSource.DataSource = dt;
            rentalDgv.DataSource = bindingSource;
             con.close();


        }
        private void populateReturn()
        {
            con.open();
            //string query = "Select * from ReturnTABLE";
             SqlDataAdapter apr = new SqlDataAdapter(query,con);
             DataTable dt=new DataTable();
            apr.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            returnDgv.DataSource = bindingSource;
            con.close();


        }
        private void updatecar()
        {
            string Status= "Yes";
            try
            {
                con.open();
               // string query="update CARTABLE set Availabe='"&Status&"' where Cid='"& regno.Text &"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.close();
            }
        }
        private void delete()
        {
            try
            {
                con.open();
                //string query = "delete from RENTTABLE where Rid=" & key & " ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Return_Load(object sender, EventArgs e)
        {
            populate();
        }
        DateTime Myreturn;
        int key = 0;
        private void rentalDgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow row = rentalDgv.Rows(e.RowIndex);
             regno.Text=row.Cells(1).Value.ToString();
             custname.Text =row.Cells(3).Value.ToString();
             returndate.Text=row.Cells(5).Value.ToString();
            Myreturn=row.Cells(5).Value;
            if (regno.Text == "")
            {
                key = 0;
            }
            else
            {
                key=row.Cells(0).Value;
            }
            
        }
        private void CalculateDelay()
        {

            TimeSpan diff = DateTime.Today.Date - (Convert.ToDateTime(returndate.Text));
            double Days = diff.TotalDays;
            if (Days <= 0)
            {
                Days = 0;
                Delay.Text = "No Delay";
            }
            else
            {
                Delay.Text = Days.ToString();
            }
            double Fine = Days * 500;
            Delay.Text = Days.ToString();
        }

        private void calculateFine()
        {


            if (Delay.Text == "No Delay")
            {

                fine.Text = "No Fine";
            }
            else
            {
                double Days = Convert.ToDouble(Delay.Text);
                double Fine = Days * 500;
                fine.Text = Fine.ToString() + "Birr";
            }


        }

        private void Delay_TextChanged(object sender, EventArgs e)
        {
            CalculateDelay();
        }

        private void fine_TextChanged(object sender, EventArgs e)
        {
            calculateFine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (custname.Text == "" || Delay.Text == "")
            {
                MessageBox.Show("Select The car to Return");
            }
            else
            {
                int delay;
                Double fin;
                 if(Delay.Text=="No Delay")
                {
                    delay = 0;
                  

                }
                else
                {
                    delay=int.Parse(Delay.Text);

                }
                 if(fine.Text=="No Fine")
                {
                    fin = 0;
                }
                else
                {
                    fin = int.Parse(fine.Text);
                }

                try
                {
                    con.opne();
                    //  string  query="insert into RETURNTABLE values ('"&regno.Text& "', '"&custname.Text&"', '"Myreturn"','"&delay&"', '"&fin&"');
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car SuccessFully Retuned");
                    con.close();
                    populateReturn();
                    updatecar();
                    delete();


                }
                catch(Exception ex)
                {

                }

            }

        }
    }
}
