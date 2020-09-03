namespace ImageFilterLibrary
{
    public static class QualityExtension
    {
        public static void Quality(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Quality(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
