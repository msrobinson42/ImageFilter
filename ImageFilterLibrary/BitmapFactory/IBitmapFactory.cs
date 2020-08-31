using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.BitmapFactory
{
    public interface IBitmapFactory
    {
        public Bitmap GetInstance(Bitmap image);
    }
}
