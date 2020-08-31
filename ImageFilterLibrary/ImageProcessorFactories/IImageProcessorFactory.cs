using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.ImageProcessorFactories
{
    public interface IImageProcessorFactory
    {
        public ImageFactory GetInstance(Bitmap image);
        public ImageFactory GetInstance();
    }
}
