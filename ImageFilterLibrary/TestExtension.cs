using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary
{
    public static class TestExtension
    {
        public static void Test(this ImageEditorState @this, int radius)
        {
            //var newImage = new Bitmap(@this.Image);

            //var factory = new ImageFactory();

            //factory.Load(newImage);
            //factory.Pixelate(50);

            var newImage = ImageProcessor.Instance.Pixellate(@this.Image, radius);

            //newImage = (Bitmap)factory.Image;

            @this.Update(newImage);

            //factory.Dispose();

        }
    }
}
