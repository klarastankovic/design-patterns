using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageEncrypt
{
    public abstract class Message
    {
        public IEncryption Encryption { get; set; }
        protected String Author { get; set; }
        protected String Text { get; set; }
        public Message(String author, String message)
        {
            this.Text = message; this.Author = author; this.Encryption = new PlainText();
        }
        public abstract String Encrypt();
    }
}
