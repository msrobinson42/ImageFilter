using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
{
    public class LockBitsTestCommand : IBitmapEffectCommand
    {
        private readonly Bitmap _image;

        public LockBitsTestCommand(Bitmap image)
        {
            _image = image;
        }

        public Bitmap Execute()
        {
            throw new NotImplementedException();
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
