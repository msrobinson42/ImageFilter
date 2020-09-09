using System.Drawing;

namespace ImageFilterLibrary
{
    public static class BackgroundColorExtension
    {
        /// <summary>
        /// Changes the background color of the image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="color">The new color of the background.</param>
        public static void BackgroundColor(this ImageEditorState @this, Color color)
        {
            var newImage = ImageProcessor.Instance.BackgroundColor(@this.Image, color);

            @this.Update(newImage);
        }
    }
}
