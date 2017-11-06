using CandyFramework.Core.Enum;
using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Entity.Base
{
    public abstract class UserGroup : IUserGroup
    {
        public int Id { get; set; }
        public DbStateEnum State { get; set; }
        public string Name { get; set; }
    }
}
