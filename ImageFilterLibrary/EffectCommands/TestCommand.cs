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
        private readonly CommandFacade _facade;
        private readonly int _radius;

        public TestCommand(CommandFacade facade, int? radius = 50)
        {
            _facade = facade ?? throw new ArgumentNullException(nameof(facade));
            _radius = radius ?? 50;
        }

        //Execute() adds a Pixelate/Mosaic effect to the image.
        public Bitmap Execute()
        {

            //_facade.ImageFactory.Pixelate(_radius);

            //var imageAfterFilter = _facade.ImageFactory.Image;

            //var result = _facade.BitmapFactory.GetInstance(imageAfterFilter);

            //return result;

            var imgAfterFilter = _facade.ImageFactory
                .Pixelate(_radius)
                .Image;

            return _facade.BitmapFactory.GetInstance(imgAfterFilter);
        }

        public Bitmap Unexecute()
        {
            return _facade.InitialImage;
        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            var facade = _facade.Copy(image);
            return new TestCommand(facade);
        }

        public void Dispose()
        {
            _facade.InitialImage.Dispose();
            _facade.ImageFactory.Dispose();
        }
    }
}
