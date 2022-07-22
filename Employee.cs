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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = getDataTable1();
            searchpanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Primary Key cannot Be Null");
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into Employee (ID,Name,MobileNo,Salary) Values('" + this.id.Text + "','" + this.name.Text + "','" + this.mobile.Text + "','" + this.salary.Text + "')";
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show("Record Has been saved Into Database");
                dataReader.Close();
                connection.Close();
                this.dataGridView1.DataSource = getDataTable1();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select  * from Employee where ID= '" + this.id.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() == true)
            {
                updatedata();
            }
            else
                MessageBox.Show("Employee with ID " + "" + id.Text + "" + " Does not Exits");
            dataReader.Close();
            connection.Close();
        }
        public DataTable getDataTable1()
        {
            DataTable obj = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cod = new SqlCommand("Select * from Employee", con))
                {
                    con.Open();
                    SqlDataReader reader = cod.ExecuteReader();
                    obj.Load(reader);
                }

            }
            return obj;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do You want to Delete?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "Select ID from Employee  where ID='" + this.id.Text + "';";
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    deletedata();
                }
                else
                    MessageBox.Show("Error Record Does not found");

                dataReader.Close();
                connection.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = getDataTable1();
            Category category = new Category();
            category.Visible = true;
        }
        public void updatedata()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "update Employee set ID='" + this.id.Text + "',Name='" + this.name.Text + "',MobileNo='" + this.mobile.Text + "',  Salary='" + salary.Text + "'  where ID='" + this.id.Text + "';"; 
                connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            MessageBox.Show("Record Has been updated Successfully");

            dataReader.Close();
            connection.Close();
            this.dataGridView1.DataSource = getDataTable1();
        }
        public void deletedata()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "delete from Employee  where ID='" + this.id.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            MessageBox.Show("Record Has been deleted");
            dataReader.Close();
            connection.Close();
            this.dataGridView1.DataSource = getDataTable1();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string id1 =dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            this.id.Text = id1;
            string name = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            this.name.Text = name;
            string mobile = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            this.mobile.Text = mobile;
            string salary = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            this.salary.Text = salary;
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void search1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "Select * from Employee where ID ='" + this.stxt.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() == true)
            {



                id1.Text = dataReader["ID"].ToString();
                name1.Text = dataReader["Name"].ToString();
                mobileno.Text = dataReader["MobileNO"].ToString();
                salary1.Text = dataReader["Salary"].ToString();
               

            }
            else
                MessageBox.Show("Error Record Does Not Found");




            dataReader.Close();
            connection.Close();
        }
    }
}

