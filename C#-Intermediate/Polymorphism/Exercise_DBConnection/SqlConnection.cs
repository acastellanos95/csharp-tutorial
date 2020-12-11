using System;

namespace Exercise_DBConnection
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Sql Connection opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Sql Connection closed.");
        }

        public SqlConnection(string connectionString) :base(connectionString)
        {
            
        }
    }
}