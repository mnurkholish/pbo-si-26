using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace pertemuan_8.Database
{
    public class Database
    {
        private string connString;

        public Database(string connString)
        {
            this.connString = connString;
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
