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
    public partial class Komentiraj : Form
    {
        string dbConnectionString = "data source=mysql6001.site4now.net; username=a4195e_darila; password=M4jN3j4K0r3n; persistsecurityinfo=True; database=db_a4195e_darila; SslMode=none";

        public Komentiraj()
        {
            InitializeComponent();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Komentiraj_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();
            listView3.View = View.Details;
            MySqlDataAdapter ada = new MySqlDataAdapter("SELECT id_d, v.vrsta, d.datum, d.opis, u.upor_ime FROM vrste_daril v INNER JOIN darila d ON d.id_v = v.id_v INNER JOIN uporabniki u ON d.id_u = u.id_u WHERE id_d = '" + Main.dariloID + "';", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView3.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id_d"].ToString());
                listitem.SubItems.Add(dr["vrsta"].ToString());
                listitem.SubItems.Add(dr["datum"].ToString());
                listitem.SubItems.Add(dr["opis"].ToString());
                listitem.SubItems.Add(dr["upor_ime"].ToString());
                listView3.Items.Add(listitem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            string query = "INSERT INTO komentarji (datum, komentar, id_u, id_d) VALUES ('" + DateTime.Now.ToString() + "', '" + textBox1.Text + "', '" + Prijava.userID + "', '" + Main.dariloID + "')";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();

            //MySqlConnection conn = new MySqlConnection(dbConnectionString);
            //conn.Open();
            listView2.View = View.Details;
            MySqlDataAdapter ada = new MySqlDataAdapter("SELECT k.komentar, u.upor_ime, k.datum FROM uporabniki u INNER JOIN komentarji k ON k.id_u = u.id_u INNER JOIN darila d ON k.id_d = d.id_d WHERE k.id_d = '" + Main.dariloID + "';", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView2.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["upor_ime"].ToString());
                listitem.SubItems.Add(dr["komentar"].ToString());
                listitem.SubItems.Add(dr["datum"].ToString());
                listView2.Items.Add(listitem);
            }

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();
            listView2.View = View.Details;
            MySqlDataAdapter ada = new MySqlDataAdapter("SELECT k.komentar, u.upor_ime, k.datum FROM uporabniki u INNER JOIN komentarji k ON k.id_u = u.id_u INNER JOIN darila d ON k.id_d = d.id_d WHERE k.id_d = '" + Main.dariloID + "';", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView2.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["upor_ime"].ToString());
                listitem.SubItems.Add(dr["komentar"].ToString());
                listitem.SubItems.Add(dr["datum"].ToString());
                listView2.Items.Add(listitem);
            }
        }
    }
}
