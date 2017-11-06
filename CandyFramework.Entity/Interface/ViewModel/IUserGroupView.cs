using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.ViewModel
{
    public interface IUserGroupView : IUserGroup
    {
        ICollection<UserView> Users { get; set; }
    }
}
