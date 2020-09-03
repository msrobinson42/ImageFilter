using System.Drawing;

namespace ImageFilterLibrary
{
    public static class ReplaceColorExtension
    {
        public static void ReplaceColor(this ImageEditorState @this, Color target,
            Color replacement, int fuzziness = 0)
        {
            var newImage = ImageProcessor.Instance.ReplaceColor(@this.Image, target, replacement, fuzziness);

            @this.Update(newImage);
        }
    }
}
