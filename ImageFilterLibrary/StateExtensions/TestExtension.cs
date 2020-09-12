
//An extraneous class used for testing during development.
//Zach

namespace ImageFilterLibrary
{
    public static class TestExtension
    {
        public static void Test(this ImageEditorState @this, int radius)
        {
            var newImage = ImageProcessor.Instance.Pixelate(@this.Image, radius);

            @this.Update(newImage);
        }
    }
}
