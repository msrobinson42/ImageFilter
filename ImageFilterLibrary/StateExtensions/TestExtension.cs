using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

//An extraneous class used for testing during development.

namespace ImageFilterLibrary
{
    public static class TestExtension
    {
        public static void Test(this ImageEditorState @this, int radius)
        {
            var newImage = ImageProcessor.Instance.Pixelate(@this.Image, radius);

            @this.Update(newImage);
        }
    }
}
