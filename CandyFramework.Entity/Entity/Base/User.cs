using CandyFramework.Core.Enum;
using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Entity.Base
{
    public abstract class User : IUser
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime Birtdate { get; set; }
        public virtual int Id { get; set; }
        public string UserName { get; set; }
        public DbStateEnum State { get; set; }
    }
}
