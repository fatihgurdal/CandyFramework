namespace CandyFramework.DataAccessLayer.Migrations
{
    using CandyFramework.Core.Concrete;
    using CandyFramework.Core.Concrete.Common;
    using CandyFramework.Entity.Entity.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context.CandyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }
        
    }
}
