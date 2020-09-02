using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.BitmapFactories
{
    public interface IBitmapFactory
    {
        public Bitmap GetInstance(Image image);
        public Bitmap GetInstance(string path);
    }
}
