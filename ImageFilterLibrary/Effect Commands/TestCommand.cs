using ImageFilterLibrary.BitmapFactories;
using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.ExtensionMethods;
using ImageFilterLibrary.Facades;
using ImageFilterLibrary.ImageProcessorFactories;
using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterLibrary.EffectCommands
{
    public class TestCommand : IBitmapEffectCommand
    {
        //private readonly IImageProcessorFactory _processorFactory;
        //private readonly IBitmapFactory _bitmapFactory;
        //private readonly ImageFactory _imageFactory;
        //private readonly Bitmap _bitmap;
        private readonly CommandFacade _facade;
        private readonly int _radius;

        //public TestCommand(IImageProcessorFactory processorFactory, Bitmap image, IBitmapFactory bitmapFactory, int radius = 50)
        //{
        //    _processorFactory = processorFactory;
        //    _imageFactory = _processorFactory.GetInstance(image);

        //    _bitmapFactory = bitmapFactory;
        //    _bitmap = _bitmapFactory.GetInstance(_imageFactory.Image);

        //    _radius = radius;
        //}

        public TestCommand(CommandFacade facade, int radius = 50)
        {
            _facade = facade;
            _radius = radius;
        }

        public Bitmap Execute()
        {
            var imgAfterFilter = _facade.ImageFactory
                .Pixelate(_radius)
                .Image;

            return _facade.BitmapFactory.GetInstance(imgAfterFilter);

            //_imageFactory.Pixelate(_radius);
            //return _bitmapFactory.GetInstance(_imageFactory.Image);
        }

        public Bitmap Unexecute()
        {
            return _facade.InitialImage;
            //return _bitmap;
        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            var facade = new CommandFacade(image);
            return new TestCommand(facade);
            //return new TestCommand(_processorFactory, image, _bitmapFactory, _radius);
        }

        public void Dispose()
        {
            _facade.InitialImage.Dispose();
            _facade.ImageFactory.Dispose();

            //_bitmap.Dispose();
            //_imageFactory.Dispose();
        }
    }
}
