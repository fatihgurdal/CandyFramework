using CandyFramework.Entity.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    internal static class CandyLogMap
    {
        internal static void CandyLogMapping(this DbModelBuilder builder)
        {
            var config = builder.Entity<CandyLogEntity>();

            config.ToTable("LOGS");
            config.HasKey(x => x.Id);
            config.Property(x => x.Id).HasColumnOrder(10).HasColumnType("INT").HasColumnName("ID").IsRequired();
            config.Property(x => x.Type).HasColumnOrder(11).HasColumnName("TYPE").IsRequired();
            config.Property(x => x.Level).HasColumnOrder(12).HasColumnName("LEVEL").IsRequired();
            config.Property(x => x.ErrorMessage).HasColumnOrder(13).HasColumnName("ERROR_MESSAGE").IsRequired();
            config.Property(x => x.ErrorDetail).HasColumnOrder(14).HasColumnName("ERROR_DETAIL").IsRequired();
            config.Property(x => x.InnerException).HasColumnOrder(15).HasColumnName("INNER_EXCEPTION").IsRequired();


            config.Property(x => x.CreateUser).HasColumnOrder(100).HasColumnName("CREATE_USER").IsRequired();
            config.Property(x => x.CreateDate).HasColumnOrder(101).HasColumnName("CREATE_DATE").IsRequired();
        }
    }
}
