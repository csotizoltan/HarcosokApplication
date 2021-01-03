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

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nA program leáll.", "Adatbázis kapcsolódási hiba!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            
            ListHarcosok();
            ListKepessegek();

        }


        private void DatabaseConnection()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";

            conn = new MySqlConnection(sb.ToString());
            conn.Open();
        }


        // ------- Harcosok listázása -------

        private void ListHarcosok()
        {
            harcosokListBox.Items.Clear();
            sql.CommandText = "SELECT id, nev, letrehozas FROM `harcosok`";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    int harcos_id = dr.GetInt32("id");
                    string harcos_nev = dr.GetString("nev");
                    DateTime harcos_letrehozas = dr.GetDateTime("letrehozas");

                    harcosokListBox.Items.Add(new Harcosok(harcos_id, harcos_nev, harcos_letrehozas));
                    hasznaloComboBox.Items.Add(harcos_nev);
                }
            }
        }


        // ------- Képességek listázása -------

        private void ListKepessegek()
        {
            kepessegekListBox.Items.Clear();
            kepessegLeirasaTextBox.Clear();

            if (kepessegekListBox.SelectedIndex < 0)
            {
                kepessegLeirasaTextBox.Enabled = true;
            }

            int harcosIndex = harcosokListBox.SelectedIndex + 1;
            
            sql.CommandText = "SELECT id, nev, leiras, harcos_id FROM `kepessegek` WHERE harcos_id = @harcos_index";
            sql.Parameters.AddWithValue("@harcos_index", harcosIndex);

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    int kepessegId = dr.GetInt32("id");
                    string kepessegNev = dr.GetString("nev");
                    string kepessegLeiras = dr.GetString("leiras");
                    int harcosId = dr.GetInt32("harcos_id");

                    kepessegekListBox.Items.Add(new Kepessegek(kepessegId, kepessegNev, kepessegLeiras, harcosId));
                    kepessegLeirasaTextBox.Text = kepessegLeiras;
                }
            }
            sql.Parameters.Clear();
        }


        private void buttonHarcosLetrehozasa_Click(object sender, EventArgs e)
        {

        }


        private void buttonKepessegLetrehozasa_Click(object sender, EventArgs e)
        {

        }


        private void buttonKepessegTorol_Click(object sender, EventArgs e)
        {
            
        }


        private void buttonKepessegLeirasModosit_Click(object sender, EventArgs e)
        {
            
        }


        private void harcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListKepessegek();
        }


        private void hasznaloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void harcosNeveTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
