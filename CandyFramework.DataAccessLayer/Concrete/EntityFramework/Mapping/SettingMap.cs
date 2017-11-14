using CandyFramework.Entity.Entity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    internal static class SettingMap
    {
        internal static void SettingMapping(this DbModelBuilder builder)
        {
            var config = builder.Entity<SettingEntity>();

            config.ToTable("SETTINGS");
            config.HasKey(x => x.Id);

            config.Property(x => x.CreateDate).HasColumnOrder(100).HasColumnName("CREATE_DATE").IsRequired();
            config.Property(x => x.UpdateDate).HasColumnOrder(101).HasColumnName("UPDATE_DATE").IsRequired();
            config.Property(x => x.CreateUser).HasColumnOrder(102).HasColumnName("CREATE_USER").HasMaxLength(30).IsRequired();
            config.Property(x => x.UpdateUser).HasColumnOrder(103).HasColumnName("UPDATE_USER").HasMaxLength(30).IsRequired();


            config.Property(x => x.KeyName).HasColumnName("KEYNAME").IsRequired().HasMaxLength(50);
            config.Property(x => x.Value).HasColumnName("VALUE").IsRequired().HasMaxLength(2000);

            config.Property(p => p.KeyName).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_SETTINGS_1", 1) { IsUnique = true }));
            //config.Property(p => p.IndexColmunName2).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_TABLENAME_1", 2) { IsUnique = true }));
        }
    }
}
