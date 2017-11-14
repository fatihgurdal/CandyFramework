using CandyFramework.DataAccessLayer.Concrete.EntityFramework.Base;
using CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context;
using CandyFramework.DataAccessLayer.Interface;
using CandyFramework.Entity.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework
{
    public class SettingEfRepository : EntityFrameworkRepository<SettingEntity, CandyContext>, ISettingRepository
    {
        public SettingEfRepository()
        {

        }
        public override void Add(List<SettingEntity> entities)
        {
            throw new NotSupportedException("Setting Tablosuna kayıt eklenemez.");
        }
        public override void Add(SettingEntity entity)
        {
            throw new NotSupportedException("Setting Tablosuna kayıt eklenemez.");
        }
        public override void Delete(IEnumerable<SettingEntity> entities)
        {
            throw new NotSupportedException("Setting Tablosuna kayıt eklenemez.");
        }
        public override void Delete(SettingEntity entity)
        {
            throw new NotSupportedException("Setting Tablosuna kayıt eklenemez.");
        }
    }
}
