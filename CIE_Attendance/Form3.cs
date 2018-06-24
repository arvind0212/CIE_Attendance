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
    public partial class Form3 : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataadapter;
        DataSet ds = new DataSet();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql_search = "select count(*) from studentinfo where USN='" + usn.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);

            DataTable dt = new DataTable();
            dataadapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Form4 newForm = new Form4();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Student USN Not Found");
            }

            connection.Close();

        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
            string sql = "SELECT * FROM studentinfo";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "studentinfo");

            string sql1 = "Insert into studentinfo VALUES ('" +sname.Text +"', '"+ usn.Text +"' )";
            dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
            dataadapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Successfully Registered. ");
            dataadapter.Fill(ds, "studentinfo");
            connection.Close();
            MessageBox.Show("Please Login with the Credentials Now.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }



        
    }
}
