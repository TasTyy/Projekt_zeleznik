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
    public partial class Prijava : Form
    {
        //string dbConnectionString= "data source=sql7.freemysqlhosting.net; username=sql7259467; password=GTEXuXUUmH database=sql7259467;SslMode=none;";
        string dbConnectionString = "data source=mysql6001.site4now.net; username=a4195e_darila; password=M4jN3j4K0r3n; persistsecurityinfo=True; database=db_a4195e_darila; SslMode=none";
        public static string user = "";

        public Prijava()
        {
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gumb registracija na formu prijava

            this.Hide();
            Registracija r = new Registracija();
            r.Show();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            string query = "SELECT * FROM uporabniki WHERE upor_ime = '" + uporImeTextBox.Text + "' AND geslo = '" + gesloTextBox.Text + "';";
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataReader reader = comm.ExecuteReader();

            int st = 0;
            while (reader.Read())
            {
                user = reader["upor_ime"].ToString();
                st++;
            }
            if (st == 1)
            {
                this.Hide();
                Main m = new Main();
                m.Show();
            }
            else
            {
                MessageBox.Show("Še enkrat preveri ime in priimek!");
                uporImeTextBox.Clear();
                gesloTextBox.Clear();
            }
        }
    }
}
