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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sub = 0;
            if (rb1.Checked == true)
                sub = 1;
            else if (rb2.Checked == true)
                sub = 2;
            else if (rb3.Checked == true)
                sub = 3;
            else if (rb4.Checked == true)
                sub = 4;
            else if (rb5.Checked == true)
                sub = 5;
            if (sub == 1)
            {
                float ele = 0;
                ele = float.Parse(tb1.Text) / float.Parse(tb2.Text);
                ele = ele * 100;
                String s5;
                if (ele > 75)
                    s5 = "Eligible";
                else
                    s5 = "Not Eligible";
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                string sql = "SELECT * FROM attendancem";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancem");
                string sql1 = "Insert into attendancem VALUES ('" + tbusn.Text + "', '" + int.Parse(tb1.Text) + "', '" + int.Parse(tb2.Text) + "', '" + ele + "','" + s5 + "')";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Attendance Inserted. ");
                connection.Close();
            }
            else if (sub == 2)
            {
                float ele = 0;
                ele = float.Parse(tb1.Text) / float.Parse(tb2.Text);
                ele = ele * 100;
                String s5;
                if (ele > 75)
                    s5 = "Eligible";
                else
                    s5 = "Not Eligible";
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                string sql = "SELECT * FROM attendancedb";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancedb");
                string sql1 = "Insert into attendancedb VALUES ('" + tbusn.Text + "', '" + int.Parse(tb1.Text) + "', '" + int.Parse(tb2.Text) + "', '" + ele + "','" + s5 + "')";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Attendance Inserted. ");
                connection.Close();
            }
            else if (sub == 3)
            {
                float ele = 0;
                ele = float.Parse(tb1.Text) / float.Parse(tb2.Text);
                ele = ele * 100;
                String s5;
                if (ele > 75)
                    s5 = "Eligible";
                else
                    s5 = "Not Eligible";
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                string sql = "SELECT * FROM attendancej";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancej");
                string sql1 = "Insert into attendancej VALUES ('" + tbusn.Text + "', '" + int.Parse(tb1.Text) + "', '" + int.Parse(tb2.Text) + "', '" + ele + "','" + s5 + "')";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Attendance Inserted. ");
                connection.Close();
            }
            else if (sub == 4)
            {
                float ele = 0;
                ele = float.Parse(tb1.Text) / float.Parse(tb2.Text);
                ele = ele * 100;
                String s5;
                if (ele > 75)
                    s5 = "Eligible";
                else
                    s5 = "Not Eligible";
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                string sql = "SELECT * FROM attendanceos";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendanceos");
                string sql1 = "Insert into attendanceos VALUES ('" + tbusn.Text + "', '" + int.Parse(tb1.Text) + "', '" + int.Parse(tb2.Text) + "', '" + ele + "','" + s5 + "')";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Attendance Inserted. ");
                connection.Close();
            }
            else if (sub == 5)
            {
                float ele = 0;
                ele = float.Parse(tb1.Text) / float.Parse(tb2.Text);
                ele = ele * 100; 
                String s5;
                if (ele > 75)
                    s5 = "Eligible";
                else
                    s5 = "Not Eligible";
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                string sql = "SELECT * FROM attendancedc";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "attendancedc");
                string sql1 = "Insert into attendancedc VALUES ('" + tbusn.Text + "', '" + int.Parse(tb1.Text) + "', '" + int.Parse(tb2.Text) + "', '" + ele + "','" + s5 + "')";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Attendance Inserted. ");
                connection.Close();
            }
            Form12 newForm = new Form12();
            newForm.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.Show();
            this.Hide();
        }
    }
}
