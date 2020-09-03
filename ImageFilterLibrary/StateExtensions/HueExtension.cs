namespace ImageFilterLibrary
{
    public static class HueExtension
    {
        public static void Hue(this ImageEditorState @this, int degrees, bool rotate = false)
        {
            var newImage = ImageProcessor.Instance.Hue(@this.Image, degrees, rotate);

            @this.Update(newImage);
        }
    }
}
