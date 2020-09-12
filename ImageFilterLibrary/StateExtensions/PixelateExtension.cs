using System;
using System.Collections.Generic;
using System.Text;

//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class PixelateExtension
    {
        /// <summary>
        /// Pixelates an image with the given size.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="radius">The size of the resulting pixels.</param>
        public static void Pixelate(this ImageEditorState @this, int radius)
        {
            var newImage = ImageProcessor.Instance.Pixelate(@this.Image, radius);

            @this.Update(newImage);
        }
    }
}
