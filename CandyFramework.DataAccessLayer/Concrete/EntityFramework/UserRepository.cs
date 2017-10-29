using CandyFramework.DataAccessLayer.Concrete.EntityFramework.Base;
using CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context;
using CandyFramework.Entity.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework
{
    public class UserRepository : EntityFrameworkRepository<UserEntity, CandyContext>
    {
        public UserRepository()
        {

        }
    }
}
