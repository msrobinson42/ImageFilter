using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary
{
    public sealed class ImageProcessor
    {
        private ImageProcessor()
        {

        }

        public static ImageProcessor Instance { get; } = new ImageProcessor();

        public Image Pixellate(Image image, int radius)
        {
            var factory = new ImageFactory();

            factory.Load(image);
            factory.Pixelate(radius);

            var result = factory.Image;

            factory.Dispose();

            return result;
        }
    }
}
