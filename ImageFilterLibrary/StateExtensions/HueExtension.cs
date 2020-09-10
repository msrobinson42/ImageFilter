namespace ImageFilterLibrary
{
    public static class HueExtension
    {
        /// <summary>
        /// Alters the hue of the image by changing the overall color.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="degrees">The angle by which to alter the image. Any integer between 0 and 360.</param>
        /// <param name="rotate">Whether to rotate the hue of the entire image or each pixel individually.</param>
        public static void Hue(this ImageEditorState @this, int degrees, bool rotate = false)
        {
            var newImage = ImageProcessor.Instance.Hue(@this.Image, degrees, rotate);

            @this.Update(newImage);
        }
    }
}
