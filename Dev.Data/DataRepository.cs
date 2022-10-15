using Dev.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dev.Data
{
    public class DataRepository : IDisposable
    {
        protected IDbConnection conn;
        public DataRepository()
        {
            conn = new MySqlConnection(varDirectory.dbConnection);
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
