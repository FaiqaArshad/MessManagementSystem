using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessManagement
{
    public partial class find : Form
    {
        public find()
        {
            InitializeComponent();
        }

        private void find_Load(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            DataTable menu = new DataTable();
            menu.TableName = "MenuSchedule";
            DataColumn column0 = new DataColumn();
            column0.ColumnName = "No";
            column0.DataType = Type.GetType("System.Int32");
            DataColumn column1 = new DataColumn();
            column1.ColumnName = "Days";
            column1.DataType = Type.GetType("System.String");
            DataColumn column2 = new DataColumn();
            column2.ColumnName = "Breakfast";
            column2.DataType = Type.GetType("System.String");
            DataColumn column3 = new DataColumn();
            column3.ColumnName = "Lunch";
            column3.DataType = Type.GetType("System.String");
            DataColumn column4 = new DataColumn();
            column4.ColumnName = "Dinner";
            column4.DataType = Type.GetType("System.String");
            menu.Columns.Add(column0);
            menu.Columns.Add(column1);
            menu.Columns.Add(column2);
            menu.Columns.Add(column3);
            menu.Columns.Add(column4);
            DataRow dr1 = menu.NewRow();
            dr1[0] = "1";
            dr1[1] = "Monday";
            dr1[2] = "Aloo Paratha";
            dr1[3] = "Pulao";
            dr1[4] = "Chicken Karahi";
            menu.Rows.Add(dr1);
            DataRow dr2 = menu.NewRow();
            dr2[0] = "2";
            dr2[1] = "Tuesday";
            dr2[2] = "Omelate Bread";
            dr2[3] = "Maze Rice";
            dr2[4] = "kofte";
            menu.Rows.Add(dr2);
            DataRow dr3 = menu.NewRow();
            dr3[0] = "3";
            dr3[1] = "Wednesday";
            dr3[2] = "Omelate Paratha";
            dr3[3] = "Nehari";
            dr3[4] = "Channa Dal";
            menu.Rows.Add(dr3);
            DataRow dr4 = menu.NewRow();
            dr4[0] = "4";
            dr4[1] = "Thursday";
            dr4[2] = "Halwa Puri";
            dr4[3] = "Rice";
            dr4[4] = "Haleem";
            menu.Rows.Add(dr4);
            DataRow dr5 = menu.NewRow();
            dr5[0] = "5";
            dr5[1] = "Friday";
            dr5[2] = "Paratha Channa";
            dr5[3] = "Biryani";
            dr5[4] = "Mix Vegetable";
            menu.Rows.Add(dr5);
            DataRow dr6 = menu.NewRow();
            dr6[0] = "6";
            dr6[1] = "Saturday";
            dr6[2] = "Roti";
            dr6[3] = "rice Fish";
            dr6[4] = "Quorma";
            menu.Rows.Add(dr6);
            DataRow dr7 = menu.NewRow();
            dr7[0] = "7";
            dr7[1] = "Sunday";
            dr7[2] = "Omelate Bread";
            dr7[3] = "Maze Rice";
            dr7[4] = "kofte";
            menu.Rows.Add(dr7);
            dataset.Tables.Add(menu);
            this.dataGridView1.DataSource = dataset.Tables["MenuSchedule"];

        }
    }
}
