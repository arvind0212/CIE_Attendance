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
using System.Text.RegularExpressions;


namespace CIE_AND_ATTENDENCE_PROJECT
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection connection;
        OleDbDataAdapter dataadapter;
        DataSet ds = new DataSet();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
               
                int total,tot1,tot2;
                tot1=(int.Parse(t1.Text)+int.Parse(t2.Text))/2;
                tot2=int.Parse(q1.Text)+int.Parse(q2.Text);
                total=tot1+tot2;
                if (rb1.Checked == true)
                {
                    string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                    string sql = "SELECT * FROM math";
                    OleDbConnection connection = new OleDbConnection(connetionString);
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    dataadapter.Fill(ds, "math");
                    string sql1 = "Insert into math VALUES ('" + susn.Text + "', '" + int.Parse(t1.Text) + "', '" + int.Parse(t2.Text) + "', '" + int.Parse(q1.Text) + "','" + int.Parse(q2.Text) + "', '" + total + "' )";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Marks Inserted. ");
                    connection.Close();
                }
                else if (rb2.Checked == true)
                {
                    string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                    string sql = "SELECT * FROM dbms";
                    OleDbConnection connection = new OleDbConnection(connetionString);
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    dataadapter.Fill(ds, "DBMS");
                    string sql1 = "Insert into DBMS VALUES ('" + susn.Text + "', '" + int.Parse(t1.Text) + "', '" + int.Parse(t2.Text) + "', '" + int.Parse(q1.Text) + "','" + int.Parse(q2.Text) + "', '" + total + "' )";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Marks Inserted. ");
                    connection.Close();
                }
                else if (rb3.Checked == true)
                {
                    string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                    string sql = "SELECT * FROM java";
                    OleDbConnection connection = new OleDbConnection(connetionString);
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    dataadapter.Fill(ds, "java");
                    string sql1 = "Insert into java VALUES ('" + susn.Text + "', '" + int.Parse(t1.Text) + "', '" + int.Parse(t2.Text) + "', '" + int.Parse(q1.Text) + "','" + int.Parse(q2.Text) + "', '" + total + "' )";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Marks Inserted. ");
                    connection.Close();
                }
                else if (rb4.Checked == true)
                {
                    string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                    string sql = "SELECT * FROM os";
                    OleDbConnection connection = new OleDbConnection(connetionString);
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    dataadapter.Fill(ds, "os");
                    string sql1 = "Insert into os VALUES ('" + susn.Text + "', '" + int.Parse(t1.Text) + "', '" + int.Parse(t2.Text) + "', '" + int.Parse(q1.Text) + "','" + int.Parse(q2.Text) + "', '" + total + "' )";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Marks Inserted. ");
                    connection.Close();
                }
                else if (rb5.Checked == true)
                {
                    string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
                    string sql = "SELECT * FROM dc";
                    OleDbConnection connection = new OleDbConnection(connetionString);
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    dataadapter.Fill(ds, "dc");
                    string sql1 = "Insert into dc VALUES ('" + susn.Text + "', '" + int.Parse(t1.Text) + "', '" + int.Parse(t2.Text) + "', '" + int.Parse(q1.Text) + "','" + int.Parse(q2.Text) + "', '" + total + "' )";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Marks Inserted. ");
                    connection.Close();
                }
                Form6 newForm = new Form6();
                newForm.Show();
                this.Hide();
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
            this.Hide();
        }


        
    }
}
