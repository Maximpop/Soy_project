using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
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
            catch (Exception)
            {
                MessageBox.Show("Tenging við miðlara mistókst. Tengstu við internetið.", "Tenging við miðlara mistókst", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        public List<string> RetrieveEmployeeSSN()
        {
            // List of employees. Will later be filled with data from database.
            List<string> employees = new List<string>();

            if (OpenConnection())
            {
                query = "SELECT SSN FROM employee";

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

        public string GetNameFromSSN(string SSN)
        {
            string name = null;
            
            if (OpenConnection())
            {
                query = "SELECT name FROM employee WHERE SSN = '" + SSN + "'";
                    
                SQL_Command = new MySqlCommand(query, SQL_Connection);
                name = SQL_Command.ExecuteScalar().ToString();
                    
                CloseConnection();
                return name;
            }
                
            CloseConnection();
            return name;
        }

        public void LogWork(string SSN, int bottleCount)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO SoyBottles(employeeSSN, bottles, date) VALUES ('" + SSN + "'," + bottleCount + ", NOW());";

                SQL_Command = new MySqlCommand(query, SQL_Connection);
                SQL_Command.ExecuteNonQuery();

                CloseConnection();
            }
        }
        
        public List<string> ReadFromDatabase()
        {
            List<string> records = new List<string>();
            string line = null;

            if (OpenConnection())
            {
                query = "SELECT ID, employee.name, bottles, date FROM SoyBottles join employee on (employee.SSN = SoyBottles.employeeSSN);";
                SQL_Command = new MySqlCommand(query, SQL_Connection);

                // ExecuteReader: Used to execute a command that will return 0 or more records.
                SQL_Reader = SQL_Command.ExecuteReader();

                while (SQL_Reader.Read())
                {
                    for (int i = 0; i < SQL_Reader.FieldCount; i++)
                    {
                        line += (SQL_Reader.GetValue(i).ToString()) + ";";
                    }

                    records.Add(line);
                    line = null;
                }

                CloseConnection();
                return records;
            }

            return records;
        }

        public List<string> FilterDatabase(string kt, string date)
        {
            List<string> records = new List<string>();
            string line = null;

            if (OpenConnection())
            {
                if (!String.IsNullOrEmpty(kt) && !String.IsNullOrEmpty(date))
                    query = "SELECT ID, employee.name, bottles, date FROM SoyBottles join employee on (employee.SSN = SoyBottles.employeeSSN) WHERE employeeSSN = '" + kt + "' AND date LIKE '" + date + "%';";
                else if (String.IsNullOrEmpty(kt) && String.IsNullOrEmpty(date))
                    query = "SELECT ID, employee.name, bottles, date FROM SoyBottles join employee on (employee.SSN = SoyBottles.employeeSSN);";
                else if (!String.IsNullOrEmpty(kt) && String.IsNullOrEmpty(date))
                    query = "SELECT ID, employee.name, bottles, date FROM SoyBottles join employee on (employee.SSN = SoyBottles.employeeSSN) WHERE employeeSSN = '" + kt + "';";
                else if (String.IsNullOrEmpty(kt) && !String.IsNullOrEmpty(date))
                    query = "SELECT ID, employee.name, bottles, date FROM SoyBottles join employee on (employee.SSN = SoyBottles.employeeSSN) WHERE date LIKE '" + date + "%';";
                else
                    MessageBox.Show("Query Error");


                //query = "SELECT ID, employee.name, bottles, date FROM SoyBottles join employee on (employee.SSN = SoyBottles.employeeSSN);";


                SQL_Command = new MySqlCommand(query, SQL_Connection);

                // ExecuteReader: Used to execute a command that will return 0 or more records.
                SQL_Reader = SQL_Command.ExecuteReader();

                while (SQL_Reader.Read())
                {
                    for (int i = 0; i < SQL_Reader.FieldCount; i++)
                    {
                        line += (SQL_Reader.GetValue(i).ToString()) + ";";
                    }

                    records.Add(line);
                    line = null;
                }

                CloseConnection();
                return records;
            }

            return records;
        }

    }
}