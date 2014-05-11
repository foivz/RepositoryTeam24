using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladista
{
    class DB
    {
        
        public class DB
        {
            #region Private Fields

            private string connectionString;
            private SQLiteConnection connection;
            private static DB instance;

            #endregion

            #region Properties

            
            public string ConnectionString
            {
                get { return connectionString; }
                private set { connectionString = value; }
            }

           
            public SQLiteConnection Connection
            {
                get { return connection; }
                private set { connection = value; }
            }

            
            public static DB Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new DB();
                    }
                    return instance;
                }
            }

            #endregion

            #region Constructors

            
            private DB()
            {
                ConnectionString = @"Data Source=..\..\Baza\EvidencijaStudenataPI.db3";
                Connection = new SQLiteConnection(ConnectionString);
                Connection.Open();
            }

           
            ~DB()
            {
                Connection.Close();
                Connection = null;
            }

            #endregion

            #region Methods

           
            public DbDataReader DohvatiDataReader(string sqlUpit)
            {
                SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
                return command.ExecuteReader();
            }

           
            public object DohvatiVrijednost(string sqlUpit)
            {
                SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
                return command.ExecuteScalar();
            }

          
            public int IzvrsiUpit(string sqlUpit)
            {
                SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
                return command.ExecuteNonQuery();
            }

            #endregion
        }

    }
}
