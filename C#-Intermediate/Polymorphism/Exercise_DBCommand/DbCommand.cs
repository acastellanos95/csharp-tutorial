using Exercise_DBConnection;
using System;

namespace Exercise_DBCommand
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;
        public void Execute()
        {
            this._dbConnection.Open();
            Console.WriteLine(this._instruction);
            this._dbConnection.Close();
        }
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(dbConnection is null || String.IsNullOrEmpty(instruction))
                throw new ArgumentNullException("connection to database shouldn't be null");
            this._dbConnection = dbConnection;
            this._instruction = instruction;
        }
    }
}