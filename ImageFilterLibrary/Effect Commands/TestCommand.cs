using ImageFilterLibrary.BitmapFactory;
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
    public class TestCommand : IBitmapEffectCommand
    {
        private readonly IImageProcessorFactory _processorFactory;
        private readonly IBitmapFactory _bitmapFactory;
        private readonly ImageFactory _imageFactory;
        private readonly Bitmap _bitmap;
        private readonly int _radius;

        public TestCommand(IImageProcessorFactory processorFactory, Bitmap image, IBitmapFactory bitmapFactory, int radius = 50)
        {
            _processorFactory = processorFactory;
            _imageFactory = _processorFactory.GetInstance(image);

            _bitmapFactory = bitmapFactory;
            _bitmap = _bitmapFactory.GetInstance(_imageFactory.Image);

            _radius = radius;
        }

        public Bitmap Execute()
        {
            _imageFactory.Pixelate(_radius);

            return _bitmapFactory.GetInstance(_imageFactory.Image);
        }

        public Bitmap Unexecute() 
            => _bitmap;

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image) 
            => new TestCommand(_processorFactory, image, _bitmapFactory, _radius);

        public void Dispose()
        {
            _bitmap.Dispose();
            _imageFactory.Dispose();
        }
    }
}
