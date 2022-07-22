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
    public partial class Searchstudent : Form
    {
        public Searchstudent()
        {
            InitializeComponent();
        }

        private void Searchstudent_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "Select * from Student  where RegistrationNo='" + this.stxt.Text + "';";
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() == true)
            {
                id.Text = dataReader["RegistrationNO"].ToString();
                name.Text = dataReader["Name"].ToString();
                contact.Text = dataReader["Contact"].ToString();
                department.Text = dataReader["Department"].ToString();
                semester.Text = dataReader["Semester"].ToString();
                roomno.Text = dataReader["RoomNO"].ToString();
            }
            else
                MessageBox.Show("Error Record Does Not Found");
            dataReader.Close();
            connection.Close();
        }
    }
}
