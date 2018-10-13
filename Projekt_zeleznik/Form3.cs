using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt_zeleznik
{
    public partial class Main : Form
    {
        string dbConnectionString = "data source=mysql6001.site4now.net; username=a4195e_darila; password=M4jN3j4K0r3n; persistsecurityinfo=True; database=db_a4195e_darila; SslMode=none";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Pozdravljen " + Prijava.user.ToString() + "!";
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            
            //MySqlCommand comm = new MySqlCommand(query, conn);
            //MySqlDataReader baza = comm.ExecuteReader();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
