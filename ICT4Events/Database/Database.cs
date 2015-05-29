using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace ICT4Events.Database
{
    public class Database
    {
        //Fields
        private string _user = "DBS2Proftaak";
        private string _password = "test";
        private OracleConnection _connection;

        //Properties
        #region properties

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

        //Constructor
        public Database()
        {

        }

        //Methods
        public bool Connect()
        {
            //If there is a correct combination between username and password a connection will be established.
            try
            {
                _connection = new OracleConnection();
                _connection.ConnectionString = "User Id=" + _user + ";Password=" + _password + ";Data Source=" +
                                              " //192.168.20.28:1521/xe" + ";";
                    //orcl is de servicename (kan anders zijn, is afhankelijk van de Oracle server die geinstalleerd is. Mogelijk is ook Oracle Express: xe
                _connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Close()
        {
            //Closes connection even if it is not open.
            _connection.Close();
        }

        public void EditDatabase(string query)
        {
            if (Connect())
            {
                using (OracleCommand oracleCommand = new OracleCommand(query))
                {
                    using (oracleCommand.Connection = _connection)
                    {
                        oracleCommand.ExecuteNonQuery();
                    }
                }

                Close();
            }
        }

        public List<string>[] SelectQuery(string query, List<string> columnNames)
        {
            if (Connect())
            {
                List<string>[] dataTable = new List<string>[columnNames.Count()];

                for (int i = 0; i < columnNames.Count(); i++)
                {
                    dataTable[i] = new List<string>();
                    dataTable[i].Add(columnNames[i]);
                }

                using (OracleCommand oracleCommand = new OracleCommand(query))
                {
                    using (oracleCommand.Connection = _connection)
                    {
                        oracleCommand.Parameters.Add(":port_id", 1521);
                        OracleDataReader reader = oracleCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < columnNames.Count(); i++)
                            {
                                dataTable[i].Add(Convert.ToString(reader[columnNames[i]]));
                            }
                        }
                        Close();
                    }
                }
                return dataTable;
            }
            else
            {
                return null;
            }
        }
    }
}