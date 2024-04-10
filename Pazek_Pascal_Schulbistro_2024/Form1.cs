using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinDbase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pazek_Pascal_Schulbistro_2024
{
    public partial class Form1 : Form
    {
        // Die Datenbankverbindung erstellen
        public Dbase dbConnection = new Dbase("localhost", "schulbistro", "root", "");
        public Form2 form2;
        // Einen Datatable erstellen der später gefüllt wird, um bestimmte Funktionen nutzen zu können (Filtern)
        DataTable dtFoods = new DataTable();
        public Form1()
        {
            InitializeComponent();
            // Laden der LoadData funktion
            LoadData();
            // Verstecken der Admin Tabs
            tabControl1.TabPages.Remove(tabProductAdd);
            tabControl1.TabPages.Remove(tabProductChange);
            tabControl1.TabPages.Remove(tabStatistiken);
            // Login Form erstellen
            form2 = new Form2(this);

            // Sprachen logik um für DGV die PReis werte mit einem Punkt anzeigen zu lassen, da sie sonst als komma separiert geladen werden, was sich mit dem DB Datentyp decimal beißt
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }
        // LoadData Funktion zum füllen des Kategorie Dropdowns
        private void LoadData()
        {
            // Für jeden Wert der SQL Abfrage ein Item in die Combobox hinzufügen
            foreach (string s in dbConnection.QueryToList("select Bezeichnung from kategorie"))
            {
                cmbSorting.Items.Add(s);
            }
            // Den Default selected index der Combobox auf 0 setzen (Sonst startet das Programm mit leerer Combobox)
            cmbSorting.SelectedIndex = 0;
            // Combobox daten für Chart page
            foreach (string s in dbConnection.QueryToList("select Bezeichnung from prudukt"))
            {
                cmbProdukt.Items.Add(s);
            }
            cmbProdukt.SelectedIndex = 0;
            // Alle Produkte für das "Produkt ändern" DGV laden
            dgvProductsToChange.DataSource = dbConnection.QueryToDataTable($"SELECT P_Nr as Produktnummer, Bezeichnung as Produkt, info as Variante, Preis FROM prudukt");

            // Comboboxen auf der Produkt ändern Seite füllen
            foreach (string s in dbConnection.QueryToList("select Farbe from ampelstatus"))
            {
                cmbPC_Ampel.Items.Add(s);
                cmbAddAmpel.Items.Add(s);
            }
            foreach (string s in dbConnection.QueryToList("select Bezeichnung from kategorie"))
            {
                cmbPC_Category.Items.Add(s);
                cmbAddCategory.Items.Add(s);
            }

        }
        private void cmbProdukt_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            List<string[]> chardaten = new List<string[]>();
            chardaten = dbConnection.QueryToArrayList($"SELECT verkaufsstatistik.Datum, verkaufsstatistik.Verkaufsmenge from verkaufsstatistik, prudukt where verkaufsstatistik.P_Nr = prudukt.P_Nr and prudukt.Bezeichnung = '{cmbProdukt.Text}' order by verkaufsstatistik.Datum");
            foreach (string[] g in chardaten)
            {
                chart1.Series["Statistik"].Points.AddXY(g[0], g[1]);
            }
        }

        private void rbtnProduktstatistik_CheckedChanged(object sender, EventArgs e)
        {
            cmbProdukt.Visible = true;
        }

        private void rbtnUmsatz_CheckedChanged(object sender, EventArgs e)
        {
            cmbProdukt.Visible = false;
            chart1.Series[0].Points.Clear();
            List<string[]> chardatenUmsatz = new List<string[]>();
            chardatenUmsatz = dbConnection.QueryToArrayList($"SELECT verkaufsstatistik.Datum, SUM((verkaufsstatistik.Verkaufsmenge*prudukt.Preis)) from verkaufsstatistik, prudukt where verkaufsstatistik.P_Nr = prudukt.P_Nr group by verkaufsstatistik.Datum order by verkaufsstatistik.Datum;");
            foreach (string[] j in chardatenUmsatz)
            {
                chart1.Series["Statistik"].Points.AddXY(j[0], j[1]);
            }
        }
        // Wenn der Wert des dropdowns geändert wird, dann...
        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Wenn der initialwert = 0 ist (Manuell eingetragener "Alle Produkte" Wert)
            if (cmbSorting.SelectedIndex == 0)
            {
                // Hole ALLE Produkte aus der DB
                dtFoods = dbConnection.QueryToDataTable($"SELECT P_Nr as Produktnummer, Bezeichnung as Produkt, info as Variante, Preis FROM prudukt");
            }
            else
            {
                // Ansonsten hole die Produkte, die zur Kategorie des selected index gehören gehören
                dtFoods = dbConnection.QueryToDataTable($"SELECT P_Nr as Produktnummer, Bezeichnung as Produkt, info as Variante, Preis FROM prudukt WHERE KAT_ID = '{cmbSorting.SelectedIndex}'");
            }
            // Fülle das DataGridView mit der gefüllten variable
            dgvShowcase.DataSource = dtFoods;
        }
        // Event wenn eine Zelle in der Tabelle des DataGridViews angeklickt wird
        private void dgvShowcase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Um negative werte durch das klicken auf den Header einer Column abzufangen, gehen wir aus der Funktion wenn der Wert -1 ist
            if (e.RowIndex == -1) return;

            // Eine Variable erstellen in der die values der selected zellen gespeichert wird, um diese weiter verwenden zu können
            int item = Convert.ToInt32(dgvShowcase.Rows[e.RowIndex].Cells[0].Value);

            // Löschen des Inhalts der Zusatzstoff ListBox
            lstZusatz.Items.Clear();
            // SQL Abfrage um die Zusatzstoffe zu bekommen, mit vergleich zum "item", also dem ausgewählten Produkt einer Zelle
            foreach (string s in dbConnection.QueryToList(
                $"select zusatzstoff.Bezeichnung " +
                $"from zusatzstoff, prudukt, zusatzstoffinprodukt " +
                $"where zusatzstoff.z_id = zusatzstoffinprodukt.Z_ID " +
                $"and zusatzstoffinprodukt.P_Nr = prudukt.P_nr " +
                $"and prudukt.p_nr = {item}"))
            {
                // Werte in die ListBox der Zusatzstoffe hinzüfgen
                lstZusatz.Items.Add(s);
            }
            // Effektiv das selbe wie zuvor, nur für die Allergene
            lstAllergene.Items.Clear();
            foreach (string s in dbConnection.QueryToList(
                $"select allergen.Bezeichnung " +
                $"from allergen, prudukt, allergeninprodukt " +
                $"where allergen.a_id = allergeninprodukt.a_ID " +
                $"and allergeninprodukt.P_Nr = prudukt.P_nr " +
                $"and prudukt.p_nr = {item}"))
            {
                lstAllergene.Items.Add(s);
            }
            // Switch/Case um eine Grafik einer Ampel anzuzeigen, um den "Nutri-Wert" zu visualisieren
            // Hole den Wert "Farbe" aus Ampelstatus für das Produkt, welches in unserem "item" selected wurde
            switch (dbConnection.QueryToString("" +
                $"select Farbe " +
                $"from ampelstatus, prudukt " +
                $"where ampelstatus.status_id = prudukt.status_id " +
                $"and prudukt.p_nr = {item}"))
            {
                // Abgleichen mit verschiedenen cases um unterschiedliche Bilder zu laden
                case "Grün":
                    picAmpel.Image = Image.FromFile("../../gfx/ampel_gruen.png");
                    break;
                case "Rot":
                    picAmpel.Image = Image.FromFile("../../gfx/ampel_rot.png");
                    break;
                case "Orange":
                    picAmpel.Image = Image.FromFile("../../gfx/ampel_orange.png");

                    break;
                default:
                    break;
            }
        }
        // Simple Suchfunktion anhand der Textänderung der SearchBar, die einen Filter auf das Datagrid anwendet und dieses entsprechend filtert
        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            dtFoods.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "Produkt", txtSearchBar.Text);

        }
        // Aufrufen einer zweiten Form um den Login Prozess für Admins auszuführen; Dieser enabled dann die Admin Tabs die normalen Nutzern verwehrt werden
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Form2 loginWindow = new Form2(this);
            loginWindow.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)
            {
                grpDetails.Hide();
                grpProductChange.Show();
                dgvProductsToChange.DataSource = dbConnection.QueryToDataTable($"SELECT P_Nr as Produktnummer, Bezeichnung as Produkt, info as Variante, Preis FROM prudukt");
            }
            if (tabControl1.SelectedIndex >= 2)
            {
                grpDetails.Hide();
                grpProductChange.Hide();
            }
            if (tabControl1.SelectedIndex == 0)
            {
                grpDetails.Show();
                grpProductChange.Hide();
                if (cmbSorting.SelectedIndex == 0)
                {
                    // Hole ALLE Produkte aus der DB
                    dtFoods = dbConnection.QueryToDataTable($"SELECT P_Nr as Produktnummer, Bezeichnung as Produkt, info as Variante, Preis FROM prudukt");
                }
                else
                {
                    // Ansonsten hole die Produkte, die zur Kategorie des selected index gehören gehören
                    dtFoods = dbConnection.QueryToDataTable($"SELECT P_Nr as Produktnummer, Bezeichnung as Produkt, info as Variante, Preis FROM prudukt WHERE KAT_ID = '{cmbSorting.SelectedIndex}'");
                }
                dgvShowcase.DataSource = dtFoods;
            }

        }
        int gItem = 0;
        private void dgvProductsToChange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            int item = Convert.ToInt32(dgvShowcase.Rows[e.RowIndex].Cells[0].Value);
            gItem = item;
            foreach (string[] s in dbConnection.QueryToArrayList(
                $"select prudukt.Bezeichnung, prudukt.info, prudukt.preis " +
                $"from prudukt " +
                $"where prudukt.p_nr = {item}"))
            {

                txtPC_Name.Text = s[0];
                txtPC_Info.Text = s[1];
                txtPC_Price.Text = s[2];
            }
            foreach (string[] s in dbConnection.QueryToArrayList(
                $"select prudukt.status_ID " +
                $"from prudukt " +
                $"where prudukt.p_nr = {item}"))
            {
                cmbPC_Ampel.SelectedIndex = Convert.ToInt32(s[0]) - 1;
            }
            foreach (string[] s in dbConnection.QueryToArrayList(
                $"select prudukt.kat_id " +
                $"from prudukt " +
                $"where prudukt.p_nr = {item}"))
            {
                cmbPC_Category.SelectedIndex = Convert.ToInt32(s[0]) - 1;
            }
        }

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Convert.ToDecimal(txtPC_Price.Text));
            dbConnection.ExecuteQuery($"UPDATE prudukt Set Bezeichnung = '{txtPC_Name.Text}', Info = '{txtPC_Info.Text}', Preis = '{txtPC_Price.Text}', Kat_ID = '{cmbPC_Category.SelectedIndex + 1}', Status_ID = '{cmbPC_Ampel.SelectedIndex + 1}' where prudukt.p_nr = '{gItem}'");
            dgvProductsToChange.DataSource = dbConnection.QueryToDataTable($"SELECT P_Nr as Produktnummer, Bezeichnung as Produkt, info as Variante, Preis FROM prudukt");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            int prodNum = Convert.ToInt32(dbConnection.QueryToString("select count(p_nr) from prudukt"));
            Console.WriteLine(prodNum );
            dbConnection.ExecuteQuery(
                $"INSERT INTO prudukt (P_Nr, Bezeichnung, info, Preis, Kat_ID, Status_ID) VALUES ('{prodNum+1}', '{txtAddName.Text}', '{txtAddInfo.Text}', '{txtAddPrice.Text}', '{cmbAddCategory.SelectedIndex + 1}', '{cmbAddAmpel.SelectedIndex + 1}')");
        }
    }
}
