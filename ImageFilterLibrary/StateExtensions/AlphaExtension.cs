using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary
{
    public static class AlphaExtension
    {
        /// <summary>
        /// Changes the opacity of the image, allowing colors underneath to show through.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="percentage">The new value of each pixel's alpha, as a percentage.</param>
        public static void Alpha(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Alpha(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
