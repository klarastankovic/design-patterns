using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Playable
{
    public class Playlist : IPlayable
    {
        public String Title { get; private set; }
        List<IPlayable> clips;
        public Playlist(String title)
        {
            this.Title = title;
            this.clips = new List<IPlayable>();
        }
        public void AddVideo(IPlayable video)
        {
            this.clips.Add(video);
        }
        public void RemoveVideo(IPlayable video)
        {
            this.clips.Remove(video);
        }
        public String Play()
        {
            String Play = this.Title + Environment.NewLine;
            foreach (IPlayable clip in this.clips)
            {
                Play += clip.Play();
            }
            return Play;
        }
    }
}
