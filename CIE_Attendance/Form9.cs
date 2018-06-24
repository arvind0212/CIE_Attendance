using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CIE_AND_ATTENDENCE_PROJECT
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
            String sql;
            if (rb1.Checked == true)
            {
                sql = "SELECT * FROM attendancem where usn=" + tb1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancem");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "attendancem";
            }
            else if (rb2.Checked == true)
            {
                sql = "SELECT * FROM attendancedb where usn=" + tb1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancedb");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "attendancedb";
            }
            else if (rb3.Checked == true)
            {
                sql = "SELECT * FROM attendancej where usn=" + tb1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancej");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "attendancej";
            }
            else if (rb4.Checked == true)
            {
                sql = "SELECT * FROM attendanceos where usn=" + tb1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendanceos");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "attendanceos";
            }
            else if (rb5.Checked == true)
            {
                sql = "SELECT * FROM attendancedc where usn=" + tb1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancedc");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "attendancedc";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }
    }
}
