using System.Drawing;

//Leila with Zach review.

namespace ImageFilterLibrary
{
    public static class ReplaceColorExtension
    {
        /// <summary>
        /// Replaces a target color in the image with another replacement color. 
        /// Fuzziness allows for more general smoothing of the replacement.
        /// </summary>
        /// <param name="this">The current ImageEditorState.</param>
        /// <param name="target">The target color to be replaced.</param>
        /// <param name="replacement">The color to be placed into the image.</param>
        /// <param name="fuzziness">The smoothness/preciseness with which the color replacement will be treated. 
        /// Higher value designates a more general replacement.</param>
        public static void ReplaceColor(this ImageEditorState @this, Color target,
            Color replacement, int fuzziness = 0)
        {
            var newImage = ImageProcessor.Instance.ReplaceColor(@this.Image, target, replacement, fuzziness);

            @this.Update(newImage);
        }
    }
}
