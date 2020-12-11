using System;

namespace Exercise_DBConnection
{
    public class OracleConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Oracle Connection opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection closed.");
        }

        public OracleConnection(string connectionString) :base(connectionString)
        {
            
        }
    }
}