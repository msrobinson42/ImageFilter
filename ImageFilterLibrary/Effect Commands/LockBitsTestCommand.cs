using ImageFilterLibrary.EffectCommands;
using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterLibrary.Effect_Commands
{
    public class LockBitsTestCommand : IBitmapEffectCommand
    {
        private readonly Bitmap _image;
        private readonly int _radius;

        public LockBitsTestCommand(Bitmap image, int radius)
        {
            _image = image;
            _radius = radius;
        }

        public Bitmap Execute()
        {
            var factory = new ImageFactory();
            factory.Load(_image);
            factory.Pixelate(_radius);

            return (Bitmap)factory.Image;
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            return new LockBitsTestCommand(image, _radius);
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
