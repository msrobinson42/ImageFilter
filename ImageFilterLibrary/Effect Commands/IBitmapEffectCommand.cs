using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.EffectCommands
{
    public interface IBitmapEffectCommand
    {
        public Bitmap Execute();
        public Bitmap Unexecute();
    }
}
