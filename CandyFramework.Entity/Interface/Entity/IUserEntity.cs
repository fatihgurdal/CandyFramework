﻿using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.Entity
{
    public interface IUserEntity : IUser, ICreateEntity, IUpdateEntity
    {
        string Password { get; set; }
        byte[] ProfilPhoto { get; set; }
    }
}
