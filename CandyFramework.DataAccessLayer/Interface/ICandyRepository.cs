using CandyFramework.Core.Interface.DataAccess;
using CandyFramework.Entity.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Interface
{
    public interface ICandyRepository : IRepository<CandyLogEntity>
    {
    }
}
