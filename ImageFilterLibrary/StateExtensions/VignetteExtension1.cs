using System.Drawing;

namespace ImageFilterLibrary
{
    public static class VignetteExtension
    {
        public static void Vignette(this ImageEditorState @this, Color color)
        {
            var newImage = ImageProcessor.Instance.Vignette(@this.Image, color);

            @this.Update(newImage);
        }
    }
}
