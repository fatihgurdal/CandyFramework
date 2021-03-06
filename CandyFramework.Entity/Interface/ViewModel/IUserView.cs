﻿using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Base;

namespace CandyFramework.Entity.Interface.ViewModel
{
    public interface IUserView : IUser
    {
        string ProfilPhotoBase64 { get; set; }
        string FullName { get; set; }
        string UserGroupName { get; set; }
        UserGroupView UserGroup { get; set; }
    }
}
