namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context
{
    using CandyFramework.Core.Concrete;
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

            Database.SetInitializer(new CreateDatabaseIfNotExists<CandyContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CandyContext, Migrations.Configuration>());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.UserMapping();
            modelBuilder.UserGroupMapping();
            modelBuilder.SettingMapping();
            base.OnModelCreating(modelBuilder);

            
        }
        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries()
               .Where(
                   x =>
                       x.State == EntityState.Added || x.State == EntityState.Modified ||
                       x.State == EntityState.Deleted)) //Eklenen, düzenlenen ve silinen kayýtlar
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
    }

}