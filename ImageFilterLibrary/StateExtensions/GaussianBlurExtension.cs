
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class GaussianBlurExtension
    {
        /// <summary>
        /// **NOTE: Expensive Calculation on Large Images**
        /// Blurs the image using a kernel of Gaussian distribution.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="size">The size of the kernel used to calculate the blur.</param>
        public static void GaussianBlur(this ImageEditorState @this, int size)
        {
            var newImage = ImageProcessor.Instance.GaussianBlur(@this.Image, size);

            @this.Update(newImage);
        }
    }
}
