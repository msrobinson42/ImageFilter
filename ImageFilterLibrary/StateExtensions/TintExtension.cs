using System.Drawing;

namespace ImageFilterLibrary
{
    public static class TintExtension
    {
        public static void Tint(this ImageEditorState @this, Color hue)
        {
            var newImage = ImageProcessor.Instance.Tint(@this.Image, hue);

            @this.Update(newImage);
        }
    }
}
