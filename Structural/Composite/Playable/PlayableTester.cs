using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Playable
{
    public static class PlayableTester
    {
        public static void Test()
        {
            Playlist favourites = new Playlist("My top videos");
            Playlist funnyCatVideos = new Playlist("Cats");
            Playlist programming = new Playlist("Programming");
            Playlist cSharp = new Playlist("CSharp");
            cSharp.AddVideo(new YTVideo("Csharp1", "youtube.com/cs1"));
            cSharp.AddVideo(new YTVideo("Csharp2", "youtube.com/cs2"));
            favourites.AddVideo(new YTVideo("Gdje je pecat?", "youtube.com/pecat"));
            funnyCatVideos.AddVideo(new YTVideo("Cat fails", "youtube.com/catfail"));
            funnyCatVideos.AddVideo(new YTVideo("Cat wins", "youtube.com/catwin"));
            favourites.AddVideo(funnyCatVideos);
            programming.AddVideo(new YTVideo("Learn cpp in 20 minutes", "youtube.com/cpp"));
            programming.AddVideo(cSharp);
            favourites.AddVideo(programming);
            Console.WriteLine(favourites.Play());
        }
    }
}
