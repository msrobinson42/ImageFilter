using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.ExtensionMethods;
using ImageFilterLibrary.ImageProcessorFactory;
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
        private readonly ImageFactory _imageFactory;

        public LockBitsTestCommand(Bitmap image, int radius = 100)
        {
            _image = image;
            _radius = radius;
        }

        public LockBitsTestCommand(ImageFactory factory, int radius = 100)
        {
            _imageFactory = factory;
            _image = new Bitmap(_imageFactory.Image);
            _radius = radius;
        }

        public LockBitsTestCommand(IImageProcessorFactory proceessorFactory, Bitmap image, int radius = 50)
        {
            _imageFactory = proceessorFactory.GetImageProcessor(image);
            _image = _imageFactory.GetNewBitmapInstance();
            _radius = radius;
        }

        public Bitmap Execute()
        {
            _imageFactory.Pixelate(_radius);

            var image = new Bitmap(_imageFactory.Image);
            return image;
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            var factory = new ImageFactory().Load(image);
            return new LockBitsTestCommand(factory);
        }

        public void Dispose()
        {
            _image.Dispose();
            _imageFactory.Dispose();
        }
    }
}
