using System;

namespace Exercise_DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("sqlstring");
            OracleConnection oracleConnection = new OracleConnection("Oracle string");
            sqlConnection.Open();
            sqlConnection.Close();
            oracleConnection.Open();
            oracleConnection.Close();
        }
    }
}
