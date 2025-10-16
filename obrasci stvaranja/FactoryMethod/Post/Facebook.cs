using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Post
{
    public class Facebook : SocialNetwork
    {
        String user;
        bool privateProfile;
        public Facebook(String username, bool privateProfile)
        {
            this.user = username;
            this.privateProfile = privateProfile;
        }
        public override IPostable CreatePost(string content)
        {
            return new FacebookPost(content, privateProfile);
        }
    }
}
