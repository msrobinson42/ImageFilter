using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
{
    public class MosaicEffectCommand : IBitmapEffectCommand
    {
        private readonly Bitmap _image;

        public MosaicEffectCommand(Bitmap image)
        {
            _image = image;
        }

        public Bitmap Execute()
        {
            var newImage = new Bitmap(_image);




            return default;
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
