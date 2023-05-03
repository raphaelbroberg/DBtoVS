using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBtoVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = InfoTable.accdb";
                conn.Open();
            //MessageBox.Show("ok");

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "insert into Tabell1(Fname, Lname) values('Maryam', 'Rezaee')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data successfully saved");
        }
    }
}
