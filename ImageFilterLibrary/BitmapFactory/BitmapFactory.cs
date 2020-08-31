using System.Drawing;

namespace ImageFilterLibrary.BitmapFactory
{
    public class BitmapFactory : IBitmapFactory
    {
        public Bitmap GetInstance(Bitmap image)
        {
            return new Bitmap(image);
        }

        public Bitmap GetInstance(Image image)
        {
            return new Bitmap(image);
        }
    }
}
