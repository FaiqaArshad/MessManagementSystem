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
using System.Threading;
namespace MessManagement
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select Username , Password from LoginInformation where Username = '" + this.username.Text + "' and  Password = '" + this.password.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() == true)
            {
                passwordMatched();

            }
            else
                MessageBox.Show("Username or password is incorrect");

           // MessageBox.Show("Matched");
            dataReader.Close();
            connection.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.username.Text = "";
            //this.password.Text = "";
            Category category = new Category();

            //this.Close();

            category.Visible = true;
           // panel1.Visible = true;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void passwordMatched()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select Username  from LoginInformation where Username = '" + this.username.Text + "' and Password= '" + this.password.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            MessageBox.Show("Login Successful");
            dataReader.Close();
            connection.Close();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //Category category = new Category();          
            //category.Visible = true;

        }
        public void opennewform(object obj)
        {
            Application.Run(new Category());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
          //  panel1.Show();
            this.panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from LoginInformation where  Username ='" + this.user.Text + "';";
            connection.Open();
            SqlDataReader dataReader1 = command.ExecuteReader();
            if (dataReader1.Read() == true && this.npwd.Text == this.cpwd.Text)
            {
                updatedata();
                panel1.Visible = false;
                groupBox1.Visible = true;
            }
            else
            MessageBox.Show("Error Username does not found or new Password does not match");
            dataReader1.Close();
            connection.Close();
        }
        public void updatedata()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "update LoginInformation set Password='" + this.npwd.Text + "' where Username = '" + this.user.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            MessageBox.Show("Password Has been updated Successfully");
            dataReader.Close();
            connection.Close();
        }

        private void showpwd_Click(object sender, EventArgs e)
        {
            this.password.PasswordChar = '\0';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.password.PasswordChar = '*';
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //this.panel1.Visible = true;
            groupBox1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select Username , Password from LoginInformation where Username = '" + this.username.Text + "' and  Password = '" + this.password.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() == true)
            {
                passwordMatched();

            }
            else
                MessageBox.Show("Username or password is incorrect");

            // MessageBox.Show("Matched");
            dataReader.Close();
            connection.Close();

        }
    }
}
