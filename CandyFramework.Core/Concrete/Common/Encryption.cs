using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Concrete.Common
{
    public static class Encryption
    {
        public static string Encrypt(this string text)
        {
            return CandyFramework.Common.Encryption.Encrypter.Encrypt(text, Constants.EncryptionPassword);
        }
        public static string Decrypt(this string text)
        {
            return CandyFramework.Common.Encryption.Encrypter.Decrypt(text, Constants.EncryptionPassword);
        }
    }
}
