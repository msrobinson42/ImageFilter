using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary
{
    public static class Rotate90CWExtension
    {
        public static void Rotate90CW(this ImageEditorState @this)
        {
            var newImage = new Bitmap(@this.Image);

            newImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

            @this.Update(newImage);
        }
    }
}
