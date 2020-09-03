namespace ImageFilterLibrary
{
    public static class RoundedCornersExtension
    {
        public static void RoundedCorners(this ImageEditorState @this, int degrees)
        {
            var newImage = ImageProcessor.Instance.RoundedCorners(@this.Image, degrees);

            @this.Update(newImage);
        }
    }
}
