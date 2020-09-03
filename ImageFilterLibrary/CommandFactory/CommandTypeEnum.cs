using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary.CommandFactory
{
    public enum BitmapCommandType
    {
        Mosaic,
        Pixelate,
        Rotate180,
        Rotate90CW,
        Rotate90CCW,
        Test,
        Vignette
    }
}
