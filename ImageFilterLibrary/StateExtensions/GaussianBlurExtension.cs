namespace ImageFilterLibrary
{
    public static class GaussianBlurExtension
    {
        public static void GaussianBlur(this ImageEditorState @this, int size)
        {
            var newImage = ImageProcessor.Instance.GaussianBlur(@this.Image, size);

            @this.Update(newImage);
        }
    }
}
