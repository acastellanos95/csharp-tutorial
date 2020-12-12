using System;

namespace InterfacesAndExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            //Details of migrating the database

            _logger.LogInfo("Migration ended at {0}" + DateTime.Now);
        }
    }
}
