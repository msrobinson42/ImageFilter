using System.Drawing;

namespace ImageFilterLibrary
{
    public static class ConstrainExtension
    {
        /// <summary>
        /// Resizes an image to fit within the given dimensions while keeping it's aspect ratio.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="size">The new size that the image will be fitted to.</param>
        public static void Constrain(this ImageEditorState @this, Size size)
        {
            var newImage = ImageProcessor.Instance.Constrain(@this.Image, size);

            @this.Update(newImage);
        }
    }
}
