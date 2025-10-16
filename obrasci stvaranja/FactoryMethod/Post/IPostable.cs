using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Post
{
    public interface IPostable
    {
        String DisplayPost();
        DateTime Timestamp { get; }
    }
}
