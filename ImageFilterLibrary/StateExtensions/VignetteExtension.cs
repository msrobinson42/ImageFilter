using System.Drawing;

//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class VignetteExtension
    {
        /// <summary>
        /// Adds a Vignette effect to the image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="color">The color of the vignette effect.</param>
        public static void Vignette(this ImageEditorState @this, Color color)
        {
            var newImage = ImageProcessor.Instance.Vignette(@this.Image, color);

            @this.Update(newImage);
        }
    }
}
