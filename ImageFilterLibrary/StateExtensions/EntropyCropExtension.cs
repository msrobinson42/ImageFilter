
//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class EntropyCropExtension
    {
        /// <summary>
        /// Crops an image to the area of greatest entropy. 
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="threshold">The threshold in bytes to control the detection level.</param>
        public static void EntropyCrop(this ImageEditorState @this, byte threshold = 128)
        {
            var newImage = ImageProcessor.Instance.EntropyCrop(@this.Image, threshold);

            @this.Update(newImage);
        }
    }
}
