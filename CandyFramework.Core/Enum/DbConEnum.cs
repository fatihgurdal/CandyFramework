using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Enum
{
    public enum DbConEnum : int
    {
        StaticConnectionString = 0,
        WebConfig = 1,
        Regedit = 2,
        ReadFile = 3
    }
}
