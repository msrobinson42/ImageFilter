namespace ImageFilterLibrary
{
    public static class ContrastExtension
    {
        public static void Contrast(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Contrast(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
