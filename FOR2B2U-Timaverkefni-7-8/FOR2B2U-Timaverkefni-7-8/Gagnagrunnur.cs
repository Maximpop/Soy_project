using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace FOR2B2U_Timaverkefni_7_8
{
    class Gagnagrunnur
    {
        // Server: Segir til um hvar serverinn er hýstur.
        private string server;

        // Database: Nafnið á Gagnagrunninum sem notað er.
        private string database;

        // UID: Notendanafn MySQL grunnsins (Kennitala)
        private string UID;

        // Password: MySQL lykilorðið
        private string password;

        // Tengistrengur: Contains the connection string to connect to the database
        // and will be assigned to the connection variable.
        string tengistrengur = null;

        // Fyrirspurn: inniheldur Query til gagnagrunns
        string query = null;

        MySqlConnection SQL_Connection;
        MySqlCommand SQL_Command;
        MySqlDataReader SQL_Reader;

        // This method connects the user to the database
        public void ConnectionToDatabase()
        {
            server = "10.200.10.24";
            database = "2808982529_CS_Timaverkefni_7_8";
            UID = "2808982529";
            password = "mypassword";

            tengistrengur = "server=" + server + ";userid=" + UID + ";password=" + password + ";database=" + database;
            SQL_Connection = new MySqlConnection(tengistrengur);
        }


        // This method checks whether connection was successful or not
        private bool OpenConnection()
        {
            try
            {
                SQL_Connection.Open();
                return true;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        // This method closes the connection after use
        private bool CloseConnection()
        {
            try
            {
                SQL_Connection.Close();
                return true;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }


        // This method reads from the MySQL Database all records and displays in the respective table
        public List<string> ReadFromDatabase()
        {
            List<string> records = new List<string>();
            string line = null;

            if (OpenConnection())
            {
                query = "SELECT ID, nafn, netfang, simanumer FROM medlimir";
                SQL_Command = new MySqlCommand(query, SQL_Connection);

                // ExecuteReader: Used to execute a command that will return 0 or more records.
                SQL_Reader = SQL_Command.ExecuteReader();

                while (SQL_Reader.Read())
                {
                    for (int i = 0; i < SQL_Reader.FieldCount; i++)
                    {
                        line += (SQL_Reader.GetValue(i).ToString()) + ":";
                    }

                    records.Add(line);
                    line = null;
                }

                CloseConnection();
                return records;
            }

            return records;
        }


        public void InsertIntoTable(string kt, string nafn, string netfang, string simi)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO medlimir (ID, nafn, netfang, simanumer) VALUES ('" + kt + "','" + nafn + "','" + netfang + "','" + simi + "')";

                SQL_Command = new MySqlCommand(query, SQL_Connection);
                SQL_Command.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public string FindMember(string ID)
        {
            string lina = null;

            if (OpenConnection() == true)
            {
                query = "SELECT nafn, netfang, simanumer FROM medlimir where ID = '" + ID + "'";
                SQL_Command = new MySqlCommand(query, SQL_Connection);
                SQL_Reader = SQL_Command.ExecuteReader();

                while (SQL_Reader.Read())
                {
                    for (int i = 0; i < SQL_Reader.FieldCount; i++)
                    {
                        lina += (SQL_Reader.GetValue(i).ToString()) + ":";
                    }
                }

                SQL_Connection.Close();
            }

            return lina;

        }

        public void Erase(string ID)
        {
            if (OpenConnection())
            {
                query = "DELETE FROM medlimir where ID = '" + ID + "'";

                SQL_Command = new MySqlCommand(query, SQL_Connection);
                SQL_Command.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void Update(string kt, string nafn, string netfang, string simi)
        {
            if (OpenConnection())
            {
                query = "UPDATE medlimir SET ID = '" + kt + "', nafn = '" + nafn + "', netfang = '" + netfang + "', simanumer = '" + simi + "' where ID = '" + kt + "'";

                SQL_Command = new MySqlCommand(query, SQL_Connection);
                SQL_Command.ExecuteNonQuery();

                CloseConnection();
            }
        }
        
        public string[] FindSpecificAndReturn(string ID)
        {
            string[] data = new string[4];

            if (OpenConnection())
            {
                query = "SELECT ID, nafn, netfang, simanumer FROM medlimir where ID = '" + ID + "'";

                SQL_Command = new MySqlCommand(query, SQL_Connection);
                SQL_Reader = SQL_Command.ExecuteReader();

                while (SQL_Reader.Read())
	            {
                    data[0] = SQL_Reader.GetValue(0).ToString();
                    data[1] = SQL_Reader.GetValue(1).ToString();
                    data[2] = SQL_Reader.GetValue(2).ToString();
                    data[3] = SQL_Reader.GetValue(3).ToString();
	            }

                SQL_Reader.Close();

                CloseConnection();

                return data;
            }

            return data;
        }
        
    }
}
