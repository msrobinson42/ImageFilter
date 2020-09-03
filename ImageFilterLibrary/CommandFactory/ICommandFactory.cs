using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.CommandFactory
{
    public interface ICommandFactory
    {
        public IBitmapEffectCommand GetInstance(Bitmap image, BitmapCommandType type,
                                                params object[] variables);
    }
}
