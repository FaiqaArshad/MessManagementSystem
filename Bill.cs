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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = getDataTable1();
            string connectionString1 = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            SqlCommand command1 = new SqlCommand("Select * from Billing", connection1);
            SqlDataAdapter adp = new SqlDataAdapter(command1);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            connection1.Close();
            DataTableReader reader = new DataTableReader(ds.Tables[0]);
            while (reader.Read())
            {
                this.combo.Items.Add(reader[0]);

            }

        }
        public DataTable getDataTable1()
        {
            DataTable obj = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cod = new SqlCommand("Select * from Billing   where RegNo = '"+ combo.Text + "' ", con))
                {
                    con.Open();
                    SqlDataReader reader = cod.ExecuteReader();
                    obj.Load(reader);
                }

            }
            return obj;

        }
        public DataTable getDataTable2()
        {
            DataTable obj = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["cAStrings"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cod = new SqlCommand("Select * from Billing    ", con))
                {
                    con.Open();
                    SqlDataReader reader = cod.ExecuteReader();
                    obj.Load(reader);
                }

            }
            return obj;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = getDataTable1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = getDataTable2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                   Bitmap bmp = new Bitmap(this.dataGridView1.Width,this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0,0, this.dataGridView1.Width,this.dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 10, 10);
        }

        private void studentInformationCTRLNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeInformationCTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mealDetailCTRLMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billingOptionCTRLBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}