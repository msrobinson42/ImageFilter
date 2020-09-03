using System.Drawing;

namespace ImageFilterLibrary
{
    public static class BackgroundColorExtension
    {
        public static void BackgroundColor(this ImageEditorState @this, Color color)
        {
            var newImage = ImageProcessor.Instance.BackgroundColor(@this.Image, color);

            @this.Update(newImage);
        }
    }
}
