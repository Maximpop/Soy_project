using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace SoyProject
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
            server = "tsuts.tskoli.is";
            database = "2808982529_cs_soy";
            UID = "2808982529";
            password = "mypassword";
            
            tengistrengur = "server=" + server + ";userid=" + UID + ";password=" + password + ";database=" + database;
            SQL_Connection = new MySqlConnection(tengistrengur);
        }


        // This method checks whether connection was successful or not
        private bool OpenConnection()
        {
            if (SQL_Connection.State == System.Data.ConnectionState.Open)
                return true;

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

        public List<string> RetrieveEmployeeNames()
        {
            // List of employees. Will later be filled with data from database.
            List<string> employees = new List<string>();

            if (OpenConnection())
            {
                query = "SELECT name FROM employee";

                SQL_Command = new MySqlCommand(query, SQL_Connection);
                SQL_Reader = SQL_Command.ExecuteReader();

                while (SQL_Reader.Read())
                {
                    //if (!(employees.Contains(SQL_Reader.GetValue(0).ToString()))) // Security measure if name was accidentally added twice into the database
                        employees.Add(SQL_Reader.GetValue(0).ToString());
                }

                SQL_Reader.Close();

                CloseConnection();

                return employees;
            }
            CloseConnection();

            return employees;
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

    }
}