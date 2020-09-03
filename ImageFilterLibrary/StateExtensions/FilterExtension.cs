using ImageProcessor.Imaging.Filters.Photo;

namespace ImageFilterLibrary
{
    public static class FilterExtension
    {
        public static void Filter(this ImageEditorState @this, IMatrixFilter filter)
        {
            var newImage = ImageProcessor.Instance.Filter(@this.Image, filter);

            @this.Update(newImage);
        }
    }
}
