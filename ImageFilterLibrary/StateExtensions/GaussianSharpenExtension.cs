
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class GaussianSharpenExtension
    {
        /// <summary>
        /// **NOTE: Expensive Calculation on Large Images**
        /// Sharpens the image using a kernel of Gaussian distribution.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="size">The size of the kernel used to calculate the sharpen.</param>
        public static void GaussianSharpen(this ImageEditorState @this, int size)
        {
            var newImage = ImageProcessor.Instance.GaussianSharpen(@this.Image, size);

            @this.Update(newImage);
        }
    }
}
