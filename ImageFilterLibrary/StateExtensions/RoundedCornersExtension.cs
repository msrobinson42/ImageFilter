namespace ImageFilterLibrary
{
    public static class RoundedCornersExtension
    {
        /// <summary>
        /// Rounds the corner of the image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="radius">The radius of the corner to be added.</param>
        public static void RoundedCorners(this ImageEditorState @this, int radius)
        {
            var newImage = ImageProcessor.Instance.RoundedCorners(@this.Image, radius);

            @this.Update(newImage);
        }
    }
}
