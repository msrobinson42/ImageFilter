namespace ImageFilterLibrary
{
    public static class BrightnessExtension
    {
        public static void Brightness(this ImageEditorState @this, int percentage)
        {
            var newImage = ImageProcessor.Instance.Brightness(@this.Image, percentage);

            @this.Update(newImage);
        }
    }
}
