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
    public partial class Category : Form
    {
        Thread th;
        public Category()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void opennewform1(object obj)
        {
            Application.Run(new Meal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            s.Show();

           
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void opennewform2(object obj)
        {
            Application.Run(new Bill());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void opennewform3(object obj)
        {
            Application.Run(new Employee());
        }

        private void Category_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
          

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.N)
            {

                student.PerformClick();

            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {

                button6.PerformClick();

            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {

                button4.PerformClick();

            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {

                button6.PerformClick();

            }
            if (e.Control == true && e.KeyCode == Keys.M)
            {

                button2.PerformClick();

            }
        }

       

        private void mealDetailCTRLMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find menudetail = new find();
            menudetail.Visible = true;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentInformationCTRLNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRegistration student = new StudentRegistration();
            student.Visible = true;
        }

        private void employeeInformationCTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Visible = true;
        }
       
        private void billingOptionCTRLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Visible = true;
        }
    }
}
