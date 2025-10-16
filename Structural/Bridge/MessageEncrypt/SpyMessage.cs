using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageEncrypt
{
    public class SpyMessage : Message
    {
        private String Target { get; set; }
        public SpyMessage(string author, string text, String target) : base(author, text)
        {
            this.Target = target;
        }
        public override string Encrypt()
        {
            String text = this.Target + ":" + this.Text;
            return this.Encryption.Encrypt(text);
        }
    }
}
