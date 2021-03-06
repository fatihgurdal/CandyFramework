﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Interface.Entity
{
    public interface IViewMap<T> where T : class, IEntity
    {
        T Map();
    }
}
