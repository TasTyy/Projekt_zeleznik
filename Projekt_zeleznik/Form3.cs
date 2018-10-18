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

            string query = "SELECT * FROM vrste_daril;";
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString(1));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            string query = "INSERT INTO darila (datum, opis, id_u, id_v) VALUES ('" + DateTime.Now.ToString() + "', '" + textBox3.Text + "', (SELECT id_u FROM uporabniki WHERE ('" + Prijava.userID.ToString() + "')), (SELECT id_v FROM vrste_daril WHERE ('" + comboBox2.GetItemText(comboBox2.SelectedItem) + "')));";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            string query = "INSERT INTO darila (datum, opis, id_u, id_v) VALUES ('" + DateTime.Now.ToString() + "', '" + textBox3.Text + "', (SELECT id_u FROM uporabniki WHERE id_u = '" + Prijava.userID.ToString() + "'), (SELECT id_v FROM vrste_daril WHERE vrsta = '" + comboBox2.GetItemText(comboBox2.SelectedItem) + "'));";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //prikaze podate v bazi

            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();
            listView1.View = View.Details;
            MySqlDataAdapter ada = new MySqlDataAdapter("SELECT id_d, v.vrsta, d.datum, d.opis, u.upor_ime FROM vrste_daril v INNER JOIN darila d ON d.id_v = v.id_v INNER JOIN uporabniki u ON d.id_u = u.id_u", conn);
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

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void Ibriši_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            string query = "DELETE FROM darila WHERE id_u = (SELECT id_u FROM uporabniki WHERE id_u = '" + listView1.SelectedItems[4].Text + "')";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            string query1 = "DELETE FROM darila WHERE id_v = (SELECT id_v FROM vrste_daril WHERE id_v = '" + listView1.SelectedItems[1].Text + "')";
            MySqlCommand comm1 = new MySqlCommand(query1, conn);
            comm1.ExecuteNonQuery();
            string query4 = "DELETE FROM darila WHERE opis = '" + listView1.SelectedItems[3].Text + "')";
            MySqlCommand comm4 = new MySqlCommand(query4, conn);
            comm4.ExecuteNonQuery();
            string query2 = "DELETE FROM darila WHERE datum = '" + listView1.SelectedItems[2].Text + "')";
            MySqlCommand comm2 = new MySqlCommand(query2, conn);
            comm2.ExecuteNonQuery();
            string query3 = "DELETE FROM darila WHERE id_d = '" + listView1.SelectedItems[0].Text + "')";
            MySqlCommand comm3 = new MySqlCommand(query3, conn);
            comm3.ExecuteNonQuery();
        }
    }
}
