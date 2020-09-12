
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class BrightnessExtension
    {
        /// <summary>
        /// Changes the brightness of the image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="percentage">The amount of change in brightness of each pixel, as a percentage.</param>
        public static void Brightness(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Brightness(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
