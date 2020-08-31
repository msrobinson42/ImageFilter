using ImageFilterLibrary.BitmapFactories;
using ImageFilterLibrary.ImageProcessorFactories;
using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Facades
{
    public class CommandFacade
    {
        private static readonly IImageProcessorFactory _processorFactory;
        private static readonly IBitmapFactory _bitmapFactory;

        static CommandFacade()
        {
            _processorFactory = new ImageProcessorFactory();
            _bitmapFactory = new BitmapFactory();
        }

        public CommandFacade(Bitmap image)
        {
            ImageFactory = _processorFactory.GetInstance(image);
            BitmapFactory = _bitmapFactory;
            InitialImage = image;
        }

        public ImageFactory ImageFactory { get; }
        public IBitmapFactory BitmapFactory { get; }
        public Bitmap InitialImage { get; }
    }
}
