using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Post
{
    public abstract class SocialNetwork
    {
        public abstract IPostable CreatePost (String content);
    }
}
