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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
            String sql;
            if (rb1.Checked == true)
            {
                sql = "SELECT * FROM math where usn=" + textBox1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "math");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "math";
            }
            else if (rb2.Checked == true)
            {
                sql = "SELECT * FROM dbms where usn=" + textBox1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "dbms");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dbms";
            }
            else if (rb3.Checked == true)
            {
                sql = "SELECT * FROM java where usn=" + textBox1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "java");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "java";
            }
            else if (rb4.Checked == true)
            {
                sql = "SELECT * FROM os where usn=" + textBox1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "os");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "os";
            }
            else if (rb5.Checked == true)
            {
                sql = "SELECT * FROM dc where usn=" + textBox1.Text;
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "dc");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dc";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
            this.Hide();
        }
    }
}
