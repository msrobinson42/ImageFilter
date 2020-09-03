using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.EffectCommands
{
    public interface IBitmapEffectCommand : IDisposable
    {
        public Bitmap Execute();
        public Bitmap Unexecute();
        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image);
    }
}
