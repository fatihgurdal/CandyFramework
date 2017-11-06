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
    internal static class UserGroupMap
    {
        internal static void UserGroupMapping(this DbModelBuilder builder)
        {
            var config = builder.Entity<UserGroupEntity>();

            config.ToTable("USER_GROUP");
            config.HasKey(x => x.Id);

            config.Property(x => x.Name).HasColumnName("NAME").IsRequired().HasMaxLength(100);
            config.Property(x => x.State).HasColumnName("STATE").IsRequired();
            config.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            config.Property(x => x.UpdateDate).HasColumnName("UPDATE_DATE").IsRequired();
            config.Property(x => x.CreateUser).HasColumnName("CREATE_USER").HasMaxLength(30).IsRequired();
            config.Property(x => x.UpdateUser).HasColumnName("UPDATE_USER").HasMaxLength(30).IsRequired();

            config.Property(p => p.Name).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USER_GROUP_NAME", 1) { IsUnique = true }));
            //config.Property(p => p.IndexColmunName2).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_TABLENAME_1", 2) { IsUnique = true }));
        }
    }
}
