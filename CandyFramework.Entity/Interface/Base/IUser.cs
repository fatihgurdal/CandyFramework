using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.Base
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        public int Id { get; set; }
        public int MyProperty { get; set; }
    }
}
