using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinDbase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Pazek_Pascal_Schulbistro_2024
{
    public partial class Form2 : Form
    {
        //Dbase dbase = new Dbase("localhost", "schulbistro", "root", "");

        public Form1 form1;

        public Form2(Form1 f)
        {

            InitializeComponent();
            //form1.Owner = this;
            form1 = f;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLoginF2_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {

            string user = txtUsername.Text;
            string password = txtPassword.Text;

            // Das in der Datenbank gespeicherte Passwort abrufen
            string hashFromDB = form1.dbConnection.QueryToString($"SELECT passwort FROM login WHERE user = '{user}'");

            // Das eingegebene Passwort hashen
            string hashedPassword = GetHashString(password);

            // Überprüfen, ob die gehashten Passwörter übereinstimmen
            if (hashedPassword == hashFromDB)
            {
                this.Hide();
                form1.tabControl1.TabPages.Add(form1.tabProductChange);
                form1.tabControl1.TabPages.Add(form1.tabProductAdd);
                form1.tabControl1.TabPages.Add(form1.tabStatistiken);
            }
            else
            {
                // Andernfalls dem Benutzer eine Fehlermeldung anzeigen
                MessageBox.Show("Falsches Passwort!");
            }

        }

        // Methode zur Berechnung des Hashwerts eines Strings
        private string GetHashString(string inputString)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
