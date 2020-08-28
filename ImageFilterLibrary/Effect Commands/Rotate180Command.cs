using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
{
    public class Rotate180Command : IBitmapEffectCommand

    {
        private readonly Bitmap _image;

        public Rotate180Command(Bitmap image)
        {
            _image = image;
        }
        public Bitmap Execute()
        {
            var newImage = new Bitmap(_image);

            newImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

            return newImage;
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
