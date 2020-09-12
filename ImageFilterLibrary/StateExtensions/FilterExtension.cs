using ImageProcessor.Imaging.Filters.Photo;

//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class FilterExtension
    {
        /// <summary>
        /// Applies an IMatrixFilter effect to the current image.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="filter">The IMatrixFilter used to apply the effect.</param>
        public static void Filter(this ImageEditorState @this, IMatrixFilter filter)
        {
            var newImage = ImageProcessor.Instance.Filter(@this.Image, filter);

            @this.Update(newImage);
        }
    }
}
