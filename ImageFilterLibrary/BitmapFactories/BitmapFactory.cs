using System.Drawing;

namespace ImageFilterLibrary.BitmapFactories
{
    public class BitmapFactory : IBitmapFactory
    {
        public Bitmap GetInstance(Image image)
        {
            return new Bitmap(image);
        }
    }
}
