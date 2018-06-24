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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=system;Password=bmscecse;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql_search = "select count(*) from faculty where eid='" + textBox1.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);

            DataTable dt = new DataTable();
            dataadapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Form5 newForm = new Form5();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Teacher ID Not Found");
            }

            connection.Close();

        }
    }
}
