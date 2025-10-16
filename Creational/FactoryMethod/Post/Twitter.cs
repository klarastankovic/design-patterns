using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Post
{
    public class Twitter : SocialNetwork
    {
        String user;
        List<String> alwaysTag;
        public Twitter(String username, List<String> tags)
        {
            this.user = username;
            this.alwaysTag = tags;
        }
        public override IPostable CreatePost(string content)
        {
            return new TwitterPost(content, alwaysTag);
        }
    }
}
