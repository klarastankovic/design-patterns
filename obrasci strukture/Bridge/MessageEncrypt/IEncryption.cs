using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageEncrypt
{
    public interface IEncryption
    {
        String Encrypt(String input);
    }
}
