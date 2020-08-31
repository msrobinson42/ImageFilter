using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.ExtensionMethods
{
    public static class ImageFactoryExtensionMethods
    {
        public static Bitmap GetNewBitmapInstance(this ImageFactory @this)
        {
            return new Bitmap(@this.Image);
        }
    }
}
