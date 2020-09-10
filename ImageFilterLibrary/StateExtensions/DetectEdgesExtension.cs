using ImageProcessor.Imaging.Filters.EdgeDetection;

namespace ImageFilterLibrary
{
    public static class DetectEdgesExtension
    {
        /// <summary>
        /// Detects the edges of an image using a particular algorithm and displays the calculated outlines.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="filter">The particular IEdgeFilter object that is used to perform the calculation.</param>
        /// <param name="greyscale">Whether or not the resulting image will be displayed as greyscale.</param>
        public static void DetectEdges(this ImageEditorState @this, IEdgeFilter filter, bool greyscale = true)
        {
            var newImage = ImageProcessor.Instance.DetectEdges(@this.Image, filter, greyscale);

            @this.Update(newImage);
        }
    }
}
