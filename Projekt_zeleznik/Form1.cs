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
        string dbConnectionString = "data source=sql7.freemysqlhosting.net; username=sql7259467; password=GTEXuXUUmH; persistsecurityinfo=True; port=3306; database=sql7259467; SslMode=none";

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

            string query = "SELECT * FROM Uporabniki WHERE upor_ime = '" + uporImeTextBox.Text + "' AND geslo = '" + gesloTextBox + "';";
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataReader baza = comm.ExecuteReader();

            int st = 0;
            while (baza.Read())
            {
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
