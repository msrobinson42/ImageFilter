using System.Drawing;

namespace ImageFilterLibrary
{
    public static class TintExtension
    {
        /// <summary>
        /// Tints the image with a given color.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="hue">The color used to tint the image.</param>
        public static void Tint(this ImageEditorState @this, Color hue)
        {
            var newImage = ImageProcessor.Instance.Tint(@this.Image, hue);

            @this.Update(newImage);
        }
    }
}
