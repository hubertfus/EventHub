using System;
using System.Data.SqlClient;
using Npgsql;

namespace EventHub
{
    public class DatabaseHelper
    {
        private string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NpgsqlConnection  GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}