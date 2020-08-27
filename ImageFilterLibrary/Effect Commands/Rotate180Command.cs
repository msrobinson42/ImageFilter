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
            _image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            return _image;
        }

        public Bitmap Unexecute()
        {
            _image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            return _image;
        }
    }
}
