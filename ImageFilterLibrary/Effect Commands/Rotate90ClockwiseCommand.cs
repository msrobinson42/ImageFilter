using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
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
            _image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            return _image;
        }

        public Bitmap Unexecute()
        {
            _image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            return _image;
        }
    }
}
