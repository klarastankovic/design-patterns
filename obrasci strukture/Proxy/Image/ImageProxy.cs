using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Image
{
    public class ImageProxy : IImage
    {
        HighResolutionImage image;
        String imageURL;
        public ImageProxy(String imageURL)
        {
            this.imageURL = imageURL;
        }
        public void ShowImage()
        {
            if (this.image == null)
            {
                this.image = new HighResolutionImage(imageURL);
            }
            this.image.ShowImage();
        }
    }
}
