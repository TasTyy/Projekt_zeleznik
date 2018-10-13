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
    public partial class Registracija : Form
    {
        string dbConnectionString = "data source=mysql6001.site4now.net; username=a4195e_darila; password=M4jN3j4K0r3n; persistsecurityinfo=True; database=db_a4195e_darila; SslMode=none";

        public Registracija()
        {
            InitializeComponent();
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            string query = "SELECT * FROM uporabniki WHERE upor_ime = '" + uporImeTextBox.Text + "' AND geslo = '" + gesloTextBox.Text + "';";
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataReader reader = comm.ExecuteReader();

            int st = 0;
            while (reader.Read())
            {
                st++;
            }
            if (st > 0)
            {
                MessageBox.Show("Uporabniško ime že obstaja!");
            }
            else
            {
                string insert = "INSERT INTO uporabniki (upor_ime, geslo) VALUES ('" + uporImeTextBox.Text + "', '" + gesloTextBox.Text + "');";
                MySqlCommand command = new MySqlCommand(insert, conn);
                reader.Close();
                command.ExecuteNonQuery();
                MessageBox.Show("Uporabnik uspešno kreiran!");
                this.Close();
                Prijava p = new Prijava();
                p.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Prijava p = new Prijava();
            p.Show();
        }
    }
}
