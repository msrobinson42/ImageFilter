using ImageProcessor.Imaging.Formats;

namespace ImageFilterLibrary
{
    public static class FormatExtension
    {
        /// <summary>
        /// Sets the output format for the current image to the matching ISupportedImageFormat.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="format">The ISupportedImageFormat object that will apply the formatting.</param>
        public static void Format(this ImageEditorState @this, ISupportedImageFormat format)
        {
            var newImage = ImageProcessor.Instance.Format(@this.Image, format);

            @this.Update(newImage);
        }
    }
}
