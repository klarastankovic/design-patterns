using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageEncrypt
{
    public class PlainText : IEncryption
    {
        public String Encrypt(String input)
        {
            return input;
        }
    }
}
