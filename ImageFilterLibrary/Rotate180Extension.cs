using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary
{
    public static class Rotate180Extension
    {
        public static void Rotate180(this ImageEditorState @this)
        {
            var newImage = new Bitmap(@this.Image);

            newImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

            @this.Update(newImage);
        }
    }

    public static class GenericRotate180Extension
    {
        public static void Rotate180(this DisposableStateMachine<Bitmap> @this)
        {
            var newImage = new Bitmap(@this.State);

            newImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

            @this.Update(newImage);
        }
    }
}
