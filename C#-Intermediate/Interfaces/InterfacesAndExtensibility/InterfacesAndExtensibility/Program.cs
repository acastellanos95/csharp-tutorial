using System;

namespace InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new FileLogger("log.txt"));
            dbMigrator.Migrate();
        }
    }
}
