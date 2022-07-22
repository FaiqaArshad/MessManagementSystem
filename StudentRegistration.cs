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
using System.Configuration;
namespace MessManagement
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string id1 = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            this.regtxt.Text = id1;
            string name = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            this.nametxt.Text = name;
            string mobile = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            this.contacttxt.Text = mobile;
            string salary = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            this.department.Text = salary;
            string sem = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            this.semester.Text = sem;
            string room = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            this.roomtxt.Text = room;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (regtxt.Text == "")
                MessageBox.Show("Primary Key cannot be Null");
            else
            {

                string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into Student (RegistrationNo,Name,Contact,Department,Semester,RoomNo) Values('" + this.regtxt.Text + "','" + this.nametxt.Text + "','" + this.contacttxt.Text + "','" + this.department.Text + "','" + this.semester.Text + "','" + this.roomtxt.Text + "')";
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show("Record Has been saved Into Database");
                dataReader.Close();
                connection.Close();
                this.regtxt.Text = "";
                this.nametxt.Text = "";
                this.department.Text = "";
                this.semester.Text = "";
                this.roomtxt.Text = "";
                this.contacttxt.Text = "";
                this.dataGridView1.DataSource = getDataTable1();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Student  where RegistrationNo='" + this.regtxt.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() == true)
            {
                updatedata();

            }
            else
                MessageBox.Show("Error Record Does Not Found");
            dataReader.Close();
            connection.Close();
            this.regtxt.Text = "";
            this.nametxt.Text = "";
            this.department.Text = "";
            this.semester.Text = "";
            this.roomtxt.Text = "";
            this.contacttxt.Text = "";
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
                command.CommandText = "select * from Student  where RegistrationNo='" + this.regtxt.Text + "';";
                //command.CommandText = "delete from Student  where RoomNo    = '" + this.roomtxt.Text + "';"; ;
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
            this.regtxt.Text = "";
            this.nametxt.Text = "";
            this.department.Text = "";
            this.semester.Text = "";
            this.roomtxt.Text = "";
            this.contacttxt.Text = "";
        }

        public DataTable getDataTable1()
        {
            DataTable obj = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cod = new SqlCommand("Select * from Student", con))
                {
                    con.Open();
                    SqlDataReader reader = cod.ExecuteReader();
                    obj.Load(reader);
                }

            }
            return obj;

        }

        private void display_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = getDataTable1();
            Category category = new Category();
            category.Visible = true;
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = getDataTable1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Searchstudent search = new Searchstudent();
            search.Visible = true;

        }
        public void deletedata()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
             command.CommandText = "delete from Student  where RegistrationNo='" + this.regtxt.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            MessageBox.Show("Record Has been deleted");
            dataReader.Close();
            connection.Close();
            this.dataGridView1.DataSource = getDataTable1();
        }
        public void updatedata()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "update Student set RegistrationNo='" + this.regtxt.Text + "',Name='" + this.nametxt.Text + "',Contact='" + this.contacttxt.Text + "',Semester='" + this.semester.Text + "',Department='" + this.department.Text + "',Roomno='" + this.roomtxt.Text + "' where RegistrationNo='" + this.regtxt.Text + "';"; connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            MessageBox.Show("Record Has been updated Successfully");

            dataReader.Close();
            connection.Close();
            this.dataGridView1.DataSource = getDataTable1();
        }

        private void StudentRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Dispose();
        }
    }
}
