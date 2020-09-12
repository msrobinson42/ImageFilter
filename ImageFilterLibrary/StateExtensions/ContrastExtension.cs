
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class ContrastExtension
    {
        /// <summary>
        /// Changes the contrast of an image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="percentage">The amount of change in contrast of the image, as a percentage.</param>
        public static void Contrast(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Contrast(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
