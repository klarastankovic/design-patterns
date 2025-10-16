using Primjeri.Utilities;
using System;
using System.Collections.Generic;

namespace Primjeri.FactoryMethod.Image
{
    class ImageExample : IExample
    {
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        public void Run()
        {
            List<Image> images = new List<Image>();
            images.Add(Image.DecodeImage("example.jpeg"));
            images.Add(Image.DecodeImage("demo.png"));
            images.Add(Image.DecodeImage("test"));

            foreach (Image image in images)
            {
                Console.WriteLine(image.Format);
            }
        }
    }
}
