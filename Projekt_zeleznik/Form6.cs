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
    public partial class Uporabnik : Form
    {
        string dbConnectionString = "data source=mysql6001.site4now.net; username=a4195e_darila; password=M4jN3j4K0r3n; persistsecurityinfo=True; database=db_a4195e_darila; SslMode=none";

        public Uporabnik()
        {
            InitializeComponent();
        }

        private void Uporabnik_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Vse objave, " + Main.uporabnik.ToString();

            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();
            listView1.View = View.Details;
            MySqlDataAdapter ada = new MySqlDataAdapter("SELECT id_d, v.vrsta, d.datum, d.opis, u.upor_ime FROM vrste_daril v INNER JOIN darila d ON d.id_v = v.id_v INNER JOIN uporabniki u ON d.id_u = u.id_u WHERE d.id_u = '" + Main.uporabnikID + "';", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id_d"].ToString());
                listitem.SubItems.Add(dr["vrsta"].ToString());
                listitem.SubItems.Add(dr["datum"].ToString());
                listitem.SubItems.Add(dr["opis"].ToString());
                listitem.SubItems.Add(dr["upor_ime"].ToString());
                listView1.Items.Add(listitem);
            }
        }
    }
}
