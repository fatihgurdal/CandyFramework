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

            config.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
            config.Property(x => x.LastName).HasMaxLength(100).IsRequired();
            config.Property(x => x.Email).HasMaxLength(100).IsRequired();
            config.Property(x => x.Password).HasMaxLength(30).IsRequired();

            config.Property(x => x.CreateUser).HasMaxLength(30).IsRequired();
            config.Property(x => x.UpdateUser).HasMaxLength(30).IsRequired();
            config.Property(x => x.UserName).HasMaxLength(30).IsRequired();

            config.Property(p => p.UserName).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USERS_1", 1) { IsUnique = true }));
            config.Property(p => p.State).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USERS_1", 2) { IsUnique = true }));
        }
    }
}
