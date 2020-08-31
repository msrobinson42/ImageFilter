using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.ImageProcessorFactory
{
    public class ImageProcessorFactory : IImageProcessorFactory
    {
        public ImageFactory GetImageProcessor(Bitmap image)
        {
            var factory = new ImageFactory();
            factory.Load(image);
            return factory;
        }
    }
}
