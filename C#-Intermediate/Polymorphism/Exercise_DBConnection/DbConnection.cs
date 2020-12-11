using System;

namespace Exercise_DBConnection
{
    public abstract class DbConnection
    {
        private string _ConnectionString;
        private TimeSpan _Timeout;

        public abstract void Open();

        public abstract void Close();

        public DbConnection(string connectionString)
        {
            if(String.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("The connection string musn't be empty");
        }


    }
}