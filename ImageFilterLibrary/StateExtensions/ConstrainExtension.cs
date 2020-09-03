using System.Drawing;

namespace ImageFilterLibrary
{
    public static class ConstrainExtension
    {
        public static void Constrain(this ImageEditorState @this, Size size)
        {
            var newImage = ImageProcessor.Instance.Constrain(@this.Image, size);

            @this.Update(newImage);
        }
    }
}
