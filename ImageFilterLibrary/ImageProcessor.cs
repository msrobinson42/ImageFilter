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
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Pixelate(radius);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Rotate(Image image, int degrees)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Rotate(degrees);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Brightness(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Brightness(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }
    }
}
