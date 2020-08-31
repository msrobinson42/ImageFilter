using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.ImageProcessorFactories
{
    public class ImageProcessorFactory : IImageProcessorFactory
    {
        public ImageFactory GetInstance(Bitmap image)
        {
            var factory = new ImageFactory();
            factory.Load(image);
            return factory;
        }

        public ImageFactory GetInstance()
        {
            return new ImageFactory();
        }
    }
}
