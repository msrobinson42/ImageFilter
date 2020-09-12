
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class QualityExtension
    {
        /// <summary>
        /// Sets the output quality of the image when saved using the ImageProcessor.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="percentage">The percentage by which to alter the image's quality. Any integer between 0 and 100.</param>
        public static void Quality(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Quality(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
