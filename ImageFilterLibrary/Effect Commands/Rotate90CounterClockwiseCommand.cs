using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
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

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
