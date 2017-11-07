using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.ViewModel
{
    public interface IUserView : IUser
    {
        string ProfilPhotoBase64 { get; set; }
        string FullName { get; set; }
        UserGroupView UserGroup { get; set; }
    }
}
