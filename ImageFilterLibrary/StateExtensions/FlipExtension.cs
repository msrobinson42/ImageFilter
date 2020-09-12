
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class FlipExtension
    {
        /// <summary>
        /// Flips the image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="verticalFlip">Whether the image will be flipped vertically or horizontally.</param>
        public static void Flip(this ImageEditorState @this, bool verticalFlip = false)
        {
            var newImage = ImageProcessor.Instance.Flip(@this.Image, verticalFlip);

            @this.Update(newImage);
        }
    }
}
