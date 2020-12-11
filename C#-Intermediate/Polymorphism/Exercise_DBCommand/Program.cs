using Exercise_DBConnection;

namespace Exercise_DBCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection sqlConnection = new OracleConnection("123456");
            DbCommand dbCommand = new DbCommand(sqlConnection, "select * from *");
            dbCommand.Execute();
        }
    }
}
