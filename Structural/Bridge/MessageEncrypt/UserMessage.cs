using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageEncrypt
{
    public class UserMessage : Message
    {
        private List<String> comments;
        public UserMessage(string author, string text) : base(author, text)
        {
            this.comments = new List<String>();
        }
        public void AddComment(String comment)
        {
            this.comments.Add(comment);
        }
        public override string Encrypt()
        {
            String text = this.Text + string.Join(",", this.comments);
            return this.Encryption.Encrypt(text);
        }
    }
}
