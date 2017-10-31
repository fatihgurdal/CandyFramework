using CandyFramework.Core.Concrete;
using CandyFramework.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CandyFramework.Core.Concrete.Common
{
    public class ConnectionProvider
    {
        internal static DbConEnum DbConnectionEnum { get; set; }
        public static string GetConnectionString()
        {
            switch (DbConnectionEnum)
            {
                case DbConEnum.StaticConnectionString:
                    return @"Data Source=.;initial catalog=CandyFramDb;User ID=sa;Password=Bimser123;Persist Security Info=True;";
                case DbConEnum.WebConfig:
                    return "name=CandyContext";
                case DbConEnum.Regedit:
                    throw new NotImplementedException("DbConEnum.Regedit ayarlanmadı.");
                case DbConEnum.ReadFile:
                    throw new NotImplementedException("DbConEnum.Regedit ayarlanmadı.");
                default:
                    throw new NotSupportedException("Connection string okuma tipi tanımsız.");
            }

        }

        internal static ThreadLocal<LogonUser> _threadlocal = new ThreadLocal<LogonUser>();

        public static LogonUser LogonUser
        {
            get
            {
                if (_threadlocal.Value == null)
                {
                    throw new Exception("Oturum Açılmadı.");
                }
                return _threadlocal.Value;
            }
            set
            {
                _threadlocal.Value = value;

            }
        }

    }
}
