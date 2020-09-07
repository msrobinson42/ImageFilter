namespace ImageFilterLibrary
{
    public static class GaussianSharpenExtension
    {
        public static void GaussianSharpen(this ImageEditorState @this, int size)
        {
            var newImage = ImageProcessor.Instance.GaussianSharpen(@this.Image, size);

            @this.Update(newImage);
        }
    }
}
