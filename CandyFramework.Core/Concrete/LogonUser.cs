using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Concrete
{
    public class LogonUser
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Lang { get; set; }
        public LogonUser()
        {

        }
        public LogonUser(string autoUserName)
        {
            if (autoUserName=="admin")
            {
                UserId = 0;
                FullName = "Framework User";
                Lang = "tr-TR";
            }
            else
            {
                throw new Exception("Belirsiz kullanıcı");
            }
        }
    }
}
