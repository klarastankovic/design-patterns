using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Post
{
    public class FacebookPost : IPostable
    {
        private DateTime timestamp;
        private String content;
        private bool isPrivate;
        public FacebookPost(String content, bool isPrivate)
        {
            this.content = content;
            this.isPrivate = isPrivate;
            this.timestamp = DateTime.Now;
        }
        public String Content { get { return content; } }
        public DateTime Timestamp { get { return timestamp; } }
        public String DisplayPost()
        {
            return GenerateHeader() + GenerateContent();
        }
        private String GenerateHeader()
        {
            return "@" + this.timestamp.ToShortDateString() + ": ";
        }
        private String GenerateContent()
        {
            return this.isPrivate ? "Hidden" : this.content;
         }
    }
}
