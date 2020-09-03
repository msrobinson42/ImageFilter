namespace ImageFilterLibrary
{
    public static class EntropyCropExtension
    {
        public static void EntropyCrop(this ImageEditorState @this, byte threshold = 128)
        {
            var newImage = ImageProcessor.Instance.EntropyCrop(@this.Image, threshold);

            @this.Update(newImage);
        }
    }
}
