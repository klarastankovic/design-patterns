using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Image
{
    public static class ImageTester
    {
        public static void Test()
        {
            IImage cat = new HighResolutionImage("https://pixabay.com/cat.jpg");
            IImage proxyCat = new ImageProxy("https://pixabay.com/cat.jpg");
            Console.WriteLine(DateTime.Now);
            cat.ShowImage();
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            proxyCat.ShowImage();
        }
    }
}
