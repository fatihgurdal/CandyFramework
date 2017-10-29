namespace CandyFramework.DataAccessLayer.Migrations
{
    using CandyFramework.Core.Concrete;
    using CandyFramework.Entity.Entity.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context.CandyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context.CandyContext context)
        {
            var logon = new LogonUser();
            Core.Common.ConnectionProvider.LogonUser = logon;

            var user = new UserEntity()
            {
                Birtdate = new DateTime(1992, 8, 30),
                FirstName = "Fatih",
                Email = "f.gurdal@hotmail.com.tr",
                LastName = "GÜRDAL",
                Password = "0",
                UserName = "fgurdal"
            };

            context.Users.Add(user);

            context.SaveChanges();

        }
    }
}
