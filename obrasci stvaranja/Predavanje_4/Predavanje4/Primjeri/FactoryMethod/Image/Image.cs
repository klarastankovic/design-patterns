using System;

namespace Primjeri.FactoryMethod.Image
{
    public class Image
    {
        private String format;
        protected Image(String format) { this.format = format; }
        public String Format { get { return this.format; } }
        public static Image DecodeImage(String imageFile)
        {
            String extension = System.IO.Path.GetExtension(imageFile);
            if (extension == ".jpeg")
            {
                return new JpegImage();
            }
            else if (extension == ".png")
            {
                return new PngImage();
            }
            else
            {
                return new Image("raw");
            }
        }
    }
}
