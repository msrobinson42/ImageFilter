using ImageProcessor.Imaging.Formats;

namespace ImageFilterLibrary
{
    public static class FormatExtension
    {
        public static void Format(this ImageEditorState @this, ISupportedImageFormat format)
        {
            var newImage = ImageProcessor.Instance.Format(@this.Image, format);

            @this.Update(newImage);
        }
    }
}
