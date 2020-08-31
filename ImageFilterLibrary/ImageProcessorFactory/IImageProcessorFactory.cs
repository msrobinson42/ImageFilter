using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.ImageProcessorFactory
{
    public interface IImageProcessorFactory
    {
        public ImageFactory GetInstance(Bitmap image);
        public ImageFactory GetInstance();
    }
}
