using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Post
{
    public class TwitterPost : IPostable
    {
        List<String> alwaysTag;
        private DateTime timestamp;
        private String content;
        public TwitterPost(String content, List<String> alwaysTag)
        {
            this.content = content;
            this.alwaysTag = alwaysTag;
            this.timestamp = DateTime.Now;
        }
        public String Content { get { return content; } }
        public DateTime Timestamp { get { return timestamp; } }
        public String DisplayPost()
        {
            return GenerateHeader() + this.Content + GenerateTags();
        }
        private String GenerateHeader()
        {
            return "@" + this.timestamp.ToShortDateString() + ": ";
        }
        private String GenerateTags()
        {
            String generatedTags = "";
            foreach (String tag in alwaysTag)
            {
                generatedTags += "#" + tag;
            }
            return generatedTags;
        }
    }
}
