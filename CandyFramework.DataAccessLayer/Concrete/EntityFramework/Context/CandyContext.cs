namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context
{
    using CandyFramework.Core.Concrete;
    using CandyFramework.Core.Concrete.Common;
    using CandyFramework.Core.Enum;
    using CandyFramework.Core.Interface.Entity;
    using CandyFramework.DataAccessLayer.Concrete.EntityFramework.Mapping;
    using CandyFramework.Entity.Entity.Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CandyContext : DbContext
    {
        public CandyContext()
            : base(Core.Concrete.Common.ConnectionProvider.GetConnectionString())
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            
            Database.SetInitializer<CandyContext>(new MyInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.UserMapping();
            modelBuilder.UserGroupMapping();
            modelBuilder.SettingMapping();
            modelBuilder.CandyLogMapping();
            base.OnModelCreating(modelBuilder);           
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries()
               .Where( x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted)) 
               //Eklenen, düzenlenen ve silinen kayýtlar
            {
                int userId =Core.Concrete.Common.ConnectionProvider.LogonUser.UserId;
                if (!(item.Entity is IEntity)) continue; // eðer veri tabaný nesnesi deðilse geç git

                //Eðer oluþturma bilgileirnin saylayan bir veri ve veri tabanýna insert iþlemi ise
                if (item.Entity is ICreateEntity && item.State == EntityState.Added)
                {
                    ((ICreateEntity)item.Entity).CreateUser = userId.ToString();
                    ((ICreateEntity)item.Entity).CreateDate = DateTime.UtcNow;
                }
                //Eðer güncelleme bilgileirnin saylayan bir veri ve veri tabanýna update iþlemi ise
                if (item.Entity is IUpdateEntity)
                {
                    if (item.State == EntityState.Added || item.State == EntityState.Deleted || item.State == EntityState.Modified)
                    {
                        ((IUpdateEntity)item.Entity).UpdateUser = userId.ToString();
                        ((IUpdateEntity)item.Entity).UpdateDate = DateTime.UtcNow;
                    }
                }
                //Eðer silinemez sadece state olarak saklanan bir veri ise ve silme iþlemi olarak geldiysa durumunu güncellemeye çek
                if (item.Entity is IState && item.State == EntityState.Deleted)
                {
                    item.State = EntityState.Modified;
                }
                if (item.Entity is IState && item.State == EntityState.Added)
                {
                    ((IState)item.Entity).State = DbStateEnum.Active;
                }
            }
            //Standart savechange iþlemine devam et.
            return base.SaveChanges();
        }

        public virtual DbSet<UserEntity> Users { get; set; }
        public virtual DbSet<UserGroupEntity> UserGroups { get; set; }
        public virtual DbSet<SettingEntity> Settings { get; set; }
        public virtual DbSet<CandyLogEntity> Logs { get; set; }

        public class MyInitializer : CreateDatabaseIfNotExists<CandyContext>
        {
            protected override void Seed(CandyContext context)
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
                    Password = "0".Encrypt(),
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

}