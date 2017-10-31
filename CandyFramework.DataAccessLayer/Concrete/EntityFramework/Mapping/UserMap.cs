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
    internal static class UserMap
    {
        internal static void UserMapping(this DbModelBuilder builder)
        {
            var config = builder.Entity<UserEntity>();

            config.ToTable("USERS");
            config.HasKey(x => x.Id);

            config.Property(x => x.Birtdate).HasColumnName("BIRTDATE").IsRequired();
            config.Property(x => x.FirstName).HasColumnName("FIRSTNAME").HasMaxLength(100).IsRequired();
            config.Property(x => x.LastName).HasColumnName("LASTNAME").HasMaxLength(100).IsRequired();
            config.Property(x => x.Email).HasColumnName("EMAIL").HasMaxLength(100).IsRequired();
            config.Property(x => x.Password).HasColumnName("PASSWORD").HasMaxLength(30).IsRequired();

            config.Property(x => x.State).HasColumnName("STATE").IsRequired();
            config.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            config.Property(x => x.UpdateDate).HasColumnName("UPDATE_DATE").IsRequired();
            config.Property(x => x.CreateUser).HasColumnName("CREATE_USER").HasMaxLength(30).IsRequired();
            config.Property(x => x.UpdateUser).HasColumnName("UPDATE_USER").HasMaxLength(30).IsRequired();
            config.Property(x => x.UserName).HasColumnName("USERNAME").HasMaxLength(30).IsRequired();

            config.Property(p => p.UserName).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USERS_1", 1) { IsUnique = true }));
            config.Property(p => p.State).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USERS_1", 2) { IsUnique = true }));
        }
    }
}
