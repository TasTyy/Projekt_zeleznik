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
    public partial class Uredi : Form
    {
        string dbConnectionString = "data source=mysql6001.site4now.net; username=a4195e_darila; password=M4jN3j4K0r3n; persistsecurityinfo=True; database=db_a4195e_darila; SslMode=none";

        public Uredi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();
            string datum = DateTime.Now.ToString();
            string query = "UPDATE darila SET datum = '" +datum+ "', opis = '" + textBox3.Text + "' WHERE id_d = '" + Main.dariloID +"'";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();

            MessageBox.Show("Podatki uspešno urejeni!");
            this.Close();
        }

        private void Uredi_Load(object sender, EventArgs e)
        {

            textBox1.Text = Main.dariloID;
            textBox2.Text = Main.datum;
            textBox3.Text = Main.opis;
        }
    }
}
