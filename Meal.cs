using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace MessManagement
{
    public partial class Meal : Form
    {
        int totall;

        public Meal()
        {
            InitializeComponent();
        }
        int nbreakfastt = 0;
        int nbreakfastt1 = 0;
        int nbreakfastt2 = 0;
        int nluncht = 0;
        int nluncht1 = 0;
        int nluncht2 = 0;
        int ndinnert = 0;
        int ndinnert1 = 0;
        int ndinnert2 = 0;
        int valb = 0;
        int vall = 0;
        int vald = 0;
        int ttotal = 0;

        public void deletedata()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "delete from Billing  where RegNo='" + this.id.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            MessageBox.Show("Record Has been deleted");
            dataReader.Close();
            connection.Close();
            this.dataGridView1.DataSource = getDataTable1();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public DataTable getDataTable1()
        {
            DataTable obj = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cod = new SqlCommand("Select * from Billing", con))
                {
                    con.Open();
                    SqlDataReader reader = cod.ExecuteReader();
                    obj.Load(reader);
                }

            }
            return obj;

        }
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do You want to Delete?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from Billing  where RegNo='" + this.id.Text + "';";

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    deletedata();
                }
                else
                    MessageBox.Show("Error Record Does Not Found");

                dataReader.Close();
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


            Tinsert();


        }




        private void Meal_Load(object sender, EventArgs e)
        {


            this.dataGridView1.DataSource = getDataTable1();
            string connectionString1 = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            SqlCommand command1 = new SqlCommand("Select * from Student", connection1);
            SqlDataAdapter adp = new SqlDataAdapter(command1);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            connection1.Close();
            DataTableReader reader = new DataTableReader(ds.Tables[0]);
            while (reader.Read())
            {
                this.id.Items.Add(reader[0]);
            }
            // string time = DateTime.Now.ToString("HH:mm:ss");
            // int nowtime = Convert.ToInt32(time.Substring(0, 2));          

        }
        private void menudetail_Click(object sender, EventArgs e)
        {
            find menudetail = new find();
            menudetail.Visible = true;
        }



        private void button5_Click(object sender, EventArgs e)
        {


        }


        public void Tinsert()
        {
            int total = 0;
            // lunch
            int nlunch1 = Convert.ToInt32(ldown.Text);

            int nlunch2 = (nlunch1 * 70);

            // breakfast
            int nbreakfast1 = Convert.ToInt32(bdown.Text);
            int nbreakfast2 = 0;
            nbreakfast2 = (nbreakfast1 * 40);
            // dinner
            int ndinner1 = Convert.ToInt32(ddown.Text);
            int ndinner2 = 0;
            ndinner2 = (ndinner1 * 60);
            // building connection
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            total = nbreakfast2 + nlunch2 + ndinner2;
            //command.CommandText = "Update Billing set RegNo='" + this.id.Text + "',Breakfast ='" + nbreakfast + "' where RegNo='" + this.id.Text + "';";
            command.CommandText = "Insert into Billing ( RegNo, Breakfast, Lunch , Dinner, Total) Values('" + this.id.Text + "' ,'" + nbreakfast2 + "','" + nlunch2 + "','" + ndinner2 + "','" + total + "' )";
            connection.Open();
            //    MessageBox.Show("Record Has been saved Into Database");
            command.ExecuteNonQuery();
            connection.Close();


            this.dataGridView1.DataSource = getDataTable1();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update1();
            ddown.Text = "0";
            bdown.Text = "0";
            ldown.Text = "0";
            nbreakfastt = 0;
           nbreakfastt1 = 0;
            nbreakfastt2 = 0;
            nluncht = 0;
            nluncht1 = 0;
            nluncht2 = 0;
            ndinnert2 = 0;
            ndinnert1 = 0;
            ndinnert = 0;
            ttotal = 0;
            
        }
    /*    public void Tupdate()
        {
            int nlunch = 0;
            int nbreakfast = 0;
            int ndinner = 0;
            int total = 0;
            int nl = 0;
            int nd = 0;

            // breakfastTup
            int nbreakfast1 = Convert.ToInt32(bdown.Value);
            int nbreakfast2 = (nbreakfast1 * 40);
            /// lunch
            int nlunch1 = Convert.ToInt32(ldown.Value);
            int nlunch2 = (nlunch1 * 70);
            // dinner
            int ndinner1 = Convert.ToInt32(ddown.Value);
            int ndinner2 = (ndinner1 * 70);
            //this.lcheck.Text = nlunch1.ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Billing";
            connection.Open();
            SqlDataReader sqlData = command.ExecuteReader();
           if (sqlData.Read()==true)
            {
                while (sqlData.Read())
                {
                    int nb = (int)sqlData["Breakfast"];
                    int total1 = (int)sqlData["Total"];
                    if (sqlData[2] == DBNull.Value)
                    {
                        string res = string.Empty;
                    }
                    else

                    {
                        nl = (int)sqlData[2];
                    }
                    if (sqlData["Dinner"] == DBNull.Value)
                    {
                        string res2 = string.Empty;
                    }
                    else

                    {
                        nd = (int)sqlData["Dinner"];
                    }
                }

                nbreakfast = nb + nbreakfast2;

                ndinner = ndinner2 + nd;
                nlunch = nl + nlunch2;
                total = (ndinner2 + nlunch2 + nbreakfast2 + total1);
                this.lcheck.Text = nd.ToString();
                this.label6.Text = nb.ToString();
            }
            sqlData.Close();
            connection.Close();
            command.CommandText = "Update Billing set Breakfast = '" + nbreakfast2 + "',Lunch ='" + nlunch + "',Dinner ='" + ndinner2 + "',Total ='" + total + "' where RegNo='" + this.id.Text + "';";
            connection.Open();
            SqlDataReader dataRead = command.ExecuteReader();
            MessageBox.Show("Record Has been saved Into Database");
            dataRead.Close();
            connection.Close();
            this.dataGridView1.DataSource = getDataTable1();

            //this.label5.Text = nl.; 


            nbreakfast2 = 0;
            nd = 0;
            nl = 0;
            //  nb = 0;
            totall = 0;
            ndinner = 0;
            nlunch = 0;
            nbreakfast = 0;
            ndinner1 = 0;
            nlunch1 = 0;
            nbreakfast1 = 0;
            ndinner2 = 09;
            nlunch2 = 0;


        }
        */
        public void update1()
        {
        

            nbreakfastt1 = Convert.ToInt32(bdown.Text);
            nbreakfastt2 = nbreakfastt2 + (nbreakfastt1 * 40);
            
            ndinnert1 = Convert.ToInt32(ddown.Text);
            ndinnert2 = ndinnert2 + (ndinnert1 * 65);
            nluncht1 = Convert.ToInt32(ldown.Text);
            nluncht2 = nluncht2 + (nluncht1 * 70);
            


            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select *  from Billing where RegNo = '" + this.id.Text+ "' ";
            connection.Open();
            SqlDataReader regData = command.ExecuteReader();
           // if (regData.Read() == true)
           // {
                while (regData.Read())
                {
                    ndinnert = (int)regData["Dinner"];
                    nluncht = (int)regData["Lunch"];
                    nbreakfastt = (int)regData["Breakfast"];

                    nbreakfastt = nbreakfastt2 + nbreakfastt;
                    nluncht = nluncht + nluncht2;
                    ndinnert = ndinnert2 + ndinnert;
                    ttotal = nbreakfastt + nluncht + ndinnert;
                }               
                regData.Close();
                connection.Close();
                command.CommandText = "Update Billing set Breakfast='" + nbreakfastt + "',Lunch='" + nluncht + "',Dinner='" + ndinnert + "', Total = '" + ttotal + "' where RegNo='" + this.id.Text + "';";
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show("Record Has been saved Into Database");
                dataReader.Close();
                connection.Close();
           // }
            this.dataGridView1.DataSource = getDataTable1();
            

        }      
    }
}   

 