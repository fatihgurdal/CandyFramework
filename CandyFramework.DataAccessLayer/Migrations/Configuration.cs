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
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context.CandyContext context)
        {
            var logon = new LogonUser();
            Core.Concrete.Common.ConnectionProvider.LogonUser = logon;


            #region - User -
            var userGroup = new UserGroupEntity()
            {
                Name = "Admin"
            };
            context.UserGroups.Add(userGroup);
            context.SaveChanges();
            var user = new UserEntity()
            {
                Birtdate = new DateTime(1992, 8, 30),
                FirstName = "Fatih",
                Email = "f.gurdal@hotmail.com.tr",
                LastName = "GÜRDAL",
                Password = "0",
                UserName = "fgurdal",
                UserGroupId = userGroup.Id
            };

            context.Users.Add(user);

            context.SaveChanges();
            #endregion
            #region - Settings -
            context.Settings.Add(new SettingEntity()
            {
                KeyName = "SuperUser",
                Value = "CandySuperUser|1445"
            });
            context.Settings.Add(new SettingEntity()
            {
                KeyName = "MailSetting",
                Value = "noreply@site.com|password|smtp.google.com|port|Candy Framework"
            });
            context.Settings.Add(new SettingEntity()
            {
                KeyName = "SiteName",
                Value = "Candy Framework"
            });
            context.Settings.Add(new SettingEntity()
            {
                KeyName = "EMailLogToAddress",
                Value = "f.gurdal@hotmail.com.tr"
            });
            context.Settings.Add(new SettingEntity()
            {
                KeyName = "EMailLogCCAddress",
                Value = "f.gurdal@hotmail.com.tr"
            });
            context.Settings.Add(new SettingEntity()
            {
                KeyName = "LogClass",
                Value = "MailLogger"
            });
            context.SaveChanges();
            #endregion

        }
    }
}
