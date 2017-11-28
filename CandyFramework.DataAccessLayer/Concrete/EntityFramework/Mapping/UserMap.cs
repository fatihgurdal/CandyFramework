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

            config.Property(x => x.Id).HasColumnName("ID").IsRequired();
            config.Property(x => x.ProfilPhoto).HasColumnName("PROFIL_PHOTO");
            config.Property(x => x.Birtdate).HasColumnName("BIRTDATE").IsRequired();
            config.Property(x => x.FirstName).HasColumnName("FIRSTNAME").HasMaxLength(100).IsRequired();
            config.Property(x => x.LastName).HasColumnName("LASTNAME").HasMaxLength(100).IsRequired();
            config.Property(x => x.Email).HasColumnName("EMAIL").HasMaxLength(100).IsRequired();
            config.Property(x => x.Password).HasColumnName("PASSWORD").HasMaxLength(30).IsRequired();
            config.Property(x => x.UserGroupId).HasColumnName("USER_GROUP_ID");

            config.Property(x => x.CreateDate).HasColumnOrder(100).HasColumnName("CREATE_DATE").IsRequired();
            config.Property(x => x.UpdateDate).HasColumnOrder(101).HasColumnName("UPDATE_DATE").IsRequired();
            config.Property(x => x.CreateUser).HasColumnOrder(102).HasColumnName("CREATE_USER").HasMaxLength(30).IsRequired();
            config.Property(x => x.UpdateUser).HasColumnOrder(103).HasColumnName("UPDATE_USER").HasMaxLength(30).IsRequired();
            config.Property(x => x.State).HasColumnName("STATE").IsRequired();
            config.Property(x => x.UserName).HasColumnName("USERNAME").HasMaxLength(30).IsRequired();

            config.Property(p => p.UserName).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USERS_1", 1) { IsUnique = true }));
            config.Property(p => p.State).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_USERS_1", 2) { IsUnique = true }));

            config.HasRequired(t => t.UserGroup).WithMany(t => t.Users).HasForeignKey(d => d.UserGroupId);
            //config.HasMany(r=>r.UserGroup).WithMany(r1=>r1.Users)
            //config.HasRequired(t => t.UserGroup).WithMany().HasForeignKey(d => d.UserGroupId);
        }
    }
}
