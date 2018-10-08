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
        string dbConnectionString = ("data source = Server=sql7.freemysqlhosting.net; Database=sql7259467; User Id=sql7259467; Password=GTEXuXUUmH;");

        public Registracija()
        {
            InitializeComponent();
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(dbConnectionString);
            myConnection.Open();

            string query = "INSERT INTO Uporabniki (upor_ime, geslo) VALUES ('" + textBox1 + "', '" + textBox2 + "');";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Prijava p = new Prijava();
            p.Show();
        }
    }
}
