using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDbase
{
    public class Dbase
    {
        private string serverName = "localhost";
        private string databaseName = string.Empty;
        private string uid = "root";
        private string passwd = string.Empty;
        private string connString = string.Empty;
        private MySqlConnection connection = null;
        private MySqlCommand command = null;      

        public Dbase(string servername, string database, string uid, string passwd)
        {
            this.serverName = servername;
            this.databaseName = database;
            this.uid = uid;
            this.passwd = passwd;
            Connect();
        }

        public void Connect()
        {
            connString = $"SERVER={serverName};DATABASE={databaseName};UID={uid};PWD={passwd}";
            try
            {
                connection = new MySqlConnection(connString);
                connection.Open();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                connection = null;
                if (MessageBox.Show(ex.Message, "Datenbank Verbindungsfehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    Connect();
            }
        }

        public DataTable QueryToDataTable(string query)
        {
            DataTable dtData = new DataTable();
            try
            {
                connection.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, connection);
                adp.Fill(dtData);
                connection.Close();
                return dtData;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
		
		public List<string> QueryToList (string query)
        {
            List<string > list = new List<string>();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                MySqlDataReader reader = new MySqlCommand(query, connection).ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader[0].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;
        }
		
		public List<string[]> QueryToArrayList(string _query)
		{
			List<string[]> listData = new List<string[]>();
			string[] row;
			try
			{
				connection.Open();
				command = new MySqlCommand(_query, connection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					row = new string[reader.FieldCount];
					for (int i = 0; i < reader.FieldCount; i++)
					{
						row[i] = reader[i].ToString();
					}
					listData.Add(row);
				}
				reader.Close();
				connection.Close();
				return listData;
			}
			catch (MySqlException ex)
			{
				if (connection != null && connection.State == System.Data.ConnectionState.Open)
					connection.Close();
				MessageBox.Show(ex.Message + $"\n\n{_query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new List<string[]>();
			}
		}		
	
		public void ExecuteQuery(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message, "Datenbank Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
		public string QueryToString(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();          
                string result = reader.GetValue(0).ToString();                
                reader.Close();
                connection.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
		
		public bool QueryToBool(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                bool hasRows = reader.HasRows;
                reader.Close();
                connection.Close();
                return hasRows;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
