using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary
{
    public static class AlphaExtension
    {
        public static void Alpha(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Alpha(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
