using System;
using System.Collections.Generic;
using System.Text;

//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class RotateExtension
    {
        /// <summary>
        /// Rotates the image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="degrees">The degrees by which the image will be rotated.</param>
        public static void Rotate(this ImageEditorState @this, int degrees)
        {
            var newImage = ImageProcessor.Instance.Rotate(@this.Image, degrees);

            @this.Update(newImage);
        }
    }
}
