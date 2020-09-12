
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class SaturationExtension
    {
        /// <summary>
        /// Changes the saturation of the image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="percentage">The percentage by which the saturation will be affected. 
        /// Any integer value between -100 and 100.</param>
        public static void Saturation(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Saturation(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
