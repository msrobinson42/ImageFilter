using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary
{
    public static class RotateExtension
    {
        public static void Rotate(this ImageEditorState @this, int degrees)
        {
            var newImage = ImageProcessor.Instance.Rotate(@this.Image, degrees);

            @this.Update(newImage);
        }
    }
}
