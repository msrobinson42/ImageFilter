using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.EffectCommands
{
    public class Rotate90ClockwiseCommand : IBitmapEffectCommand
    {
        private readonly Bitmap _image;

        public Rotate90ClockwiseCommand(Bitmap image)
        {
            _image = image;
        }

        public Bitmap Execute()
        {
            var newImage = new Bitmap(_image);

            newImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

            return newImage;
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        IBitmapEffectCommand IBitmapEffectCommand.NewCommandFromCopy(Bitmap image)
        {
            return new Rotate90ClockwiseCommand(image);
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
