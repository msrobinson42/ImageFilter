using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary
{
    public static class PixelateExtension
    {
        public static void Pixelate(this ImageEditorState @this, int radius)
        {
            var newImage = ImageProcessor.Instance.Pixelate(@this.Image, radius);

            @this.Update(newImage);
        }
    }
}
