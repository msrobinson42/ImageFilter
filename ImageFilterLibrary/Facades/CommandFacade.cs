using ImageFilterLibrary.BitmapFactory;
using ImageFilterLibrary.ImageProcessorFactory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Facades
{
    public class CommandFacade
    {
        private readonly IImageProcessorFactory _processorFactory;
        private readonly IBitmapFactory _bitmapFactory;
        private readonly Bitmap _image;

        public CommandFacade(IImageProcessorFactory imgProFactory, IBitmapFactory bmapFactory, Bitmap image)
        {
            _processorFactory = imgProFactory;

            _bitmapFactory = bmapFactory;

            _image = image;
        }

        public IBitmapFactory BitmapFactory => _bitmapFactory;

        public IImageProcessorFactory ProcessorFactory => _processorFactory;
    }
}
