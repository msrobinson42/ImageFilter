using ImageProcessor.Imaging.Filters.EdgeDetection;

namespace ImageFilterLibrary
{
    public static class DetectEdgesExtension
    {
        public static void DetectEdges(this ImageEditorState @this, IEdgeFilter filter, bool greyscale = true)
        {
            var newImage = ImageProcessor.Instance.DetectEdges(@this.Image, filter, greyscale);

            @this.Update(newImage);
        }
    }
}
