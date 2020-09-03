namespace ImageFilterLibrary
{
    public static class SaturationExtension
    {
        public static void Saturation(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Saturation(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
