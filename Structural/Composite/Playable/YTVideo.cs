using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Playable
{
    public class YTVideo : IPlayable
    {
        public String URL { get; private set; }
        public String Title { get; private set; }
        public YTVideo(String title, String url)
        {
            Title = title;
            URL = url;
        }
        public String Play()
        {
            return this.Title + " <url> "+ this.URL + " </url> "+ Environment.NewLine;
        }
    }
}
