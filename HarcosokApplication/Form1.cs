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

            hasznaloComboBox.Text = "Válassz egy harcost...";
            buttonHarcosLetrehozasa.Enabled = false; // Letiltja a Létrehozás gombot, amig nincs név megadva
            kepessegNeveTextBox.Enabled = false; // Letiltja a képesség név bevitelt még nincs kiválasztva egy harcos
            leirasTextBox.Enabled = false; // Letiltja a képesség leírás textbox-ot
            kepessegLeirasaTextBox.Enabled = false; // Letiltja a képesség leírás listbox-ot
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


        // ------- Harcos létrehozása -------

        private void CreateWarrior()
        {
            string nev = harcosNeveTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("Add meg a harcos nevét!",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                harcosNeveTextBox.Focus();
                return;
            }

            sql = conn.CreateCommand();
            sql.CommandText = "SELECT COUNT(*) FROM harcosok WHERE nev = @nev";
            sql.Parameters.AddWithValue("@nev", nev);
            long exist = (long)sql.ExecuteScalar();

            if (exist > 0)
            {
                MessageBox.Show("Ilyen néven már létezik harcos!",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                harcosNeveTextBox.Focus();
                return;
            }

            sql.Parameters.Clear();

            sql.CommandText = @"INSERT INTO harcosok (nev, letrehozas) 
                                VALUES (@harcos_nev, current_timestamp());";

            sql.Parameters.AddWithValue("@harcos_nev", nev);
            sql.ExecuteNonQuery();

            harcosokListBox.Items.Clear(); // Törlöm a harcosokListBox tartalmát
            ListHarcosok(); // majd újra kiolvasom és megjelenítem a harcosokat a listában
        }


        // ------- Képesség létrehozása -------

        private void CreateCapability()
        {
            if (hasznaloComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Először válassz ki egy harcost!",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kepessegNeve = kepessegNeveTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(kepessegNeve))
            {
                MessageBox.Show("Add meg a képesség nevét!",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kepessegNeveTextBox.Focus();
                return;
            }

            string kepesseg_leiras = leirasTextBox.Text.Trim();
            int harcosIndex = hasznaloComboBox.SelectedIndex + 1;

            sql.CommandText = @"INSERT INTO kepessegek (nev, leiras, harcos_id) 
                                VALUES (@kepesseg_nev, @kepesseg_leiras, @harcos_id);";

            sql.Parameters.AddWithValue("@kepesseg_nev", kepessegNeve);
            sql.Parameters.AddWithValue("@kepesseg_leiras", kepesseg_leiras);
            sql.Parameters.AddWithValue("@harcos_id", harcosIndex);
            sql.ExecuteNonQuery();

            MessageBox.Show("A(z) " + hasznaloComboBox.SelectedItem.ToString() + " harcoshoz a " +
                kepessegNeve + " képesség hozzáadva lett.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // ------- Képesség törlése -------

        private void DeleteCapability()
        {
            if (kepessegekListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Válaszd ki, hogy mely képességet akarod törölni!",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int harcosIndex = ((Kepessegek)kepessegekListBox.SelectedItem).Id;

            try
            {
                sql.CommandText = "DELETE FROM kepessegek WHERE id = @id";
                sql.Parameters.AddWithValue("@id", harcosIndex);
                sql.ExecuteNonQuery();

                MessageBox.Show("A " + ((Kepessegek)kepessegekListBox.SelectedItem).Nev +
                    " képesség törölve lett.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            kepessegekListBox.Items.Clear(); // Törlöm a kepessegekListBox tartalmát
            ListKepessegek(); // majd újra kiolvasom és megjelenítem a képességet a listában
        }


        // ------- Képesség módosítása -------

        private void UpdateCapability()
        {

            if (kepessegekListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Válaszd ki, hogy mely képességet akarod módosítani!",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kepesseg = kepessegLeirasaTextBox.Text.Trim();
            int kepessegIndex = ((Kepessegek)kepessegekListBox.SelectedItem).Id;
            string kepessegLeiras = kepessegLeirasaTextBox.Text.Trim();

            try
            {
                sql.CommandText = "UPDATE kepessegek SET leiras = @kepessegLeiras WHERE id = @id";

                sql.Parameters.AddWithValue("@kepessegLeiras", kepessegLeiras);
                sql.Parameters.AddWithValue("@id", kepessegIndex);
                sql.ExecuteNonQuery();

                MessageBox.Show("A " + ((Kepessegek)kepessegekListBox.SelectedItem).Nev + " képesség leírása módosítva lett.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ListKepessegek();
        }


        private void buttonHarcosLetrehozasa_Click(object sender, EventArgs e)
        {
            CreateWarrior();
        }


        private void buttonKepessegLetrehozasa_Click(object sender, EventArgs e)
        {
            CreateCapability();
        }


        private void buttonKepessegTorol_Click(object sender, EventArgs e)
        {
            DeleteCapability();
        }


        private void buttonKepessegLeirasModosit_Click(object sender, EventArgs e)
        {
            UpdateCapability();
        }


        private void harcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListKepessegek();
        }


        private void hasznaloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kepessegNeveTextBox.Enabled = true; // Engedélyezi a képesség név bevitelt, miután ki lett választva egy harcos neve
            leirasTextBox.Enabled = true; // Engedélyezi a képesség leírás textbox-ot
        }


        private void harcosNeveTextBox_TextChanged(object sender, EventArgs e)
        {
            buttonHarcosLetrehozasa.Enabled = true; // Engedélyezi a buttonHarcosLetrehozasa miután  meg lett adva egy név
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
