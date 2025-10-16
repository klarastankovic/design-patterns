using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Post
{
    public class SocialMediaAggregator
    {
        SocialNetwork socialNetwork;
        List<IPostable> posts;
        public SocialMediaAggregator(SocialNetwork socialNetwork)
        {
            this.socialNetwork = socialNetwork;
            this.posts = new List<IPostable>();
        }
        public void DisplayPosts()
        {
            foreach (IPostable post in posts)
            {
                Console.WriteLine(post.DisplayPost());
            }
        }
        public void AddPost (String content)
        {
            this.posts.Add(this.socialNetwork.CreatePost(content));
        }
    }
}
