using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.EffectCommands
{
    public class Rotate90CounterClockwiseCommand : IBitmapEffectCommand
    {
        private readonly Bitmap _image;

        public Rotate90CounterClockwiseCommand(Bitmap image)
        {
            _image = image;
        }


        public Bitmap Execute()
        {
            var newImage = new Bitmap(_image);

            newImage.RotateFlip(RotateFlipType.Rotate270FlipNone);

            return newImage;
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            return new Rotate90CounterClockwiseCommand(image);
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
