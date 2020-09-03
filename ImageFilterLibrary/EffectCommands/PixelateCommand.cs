using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.Facades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.EffectCommands
{
    public class PixelateCommand : IBitmapEffectCommand
    {
        //TODO: Leila - Finish this class.
        private readonly CommandFacade _facade;

        public PixelateCommand(CommandFacade facade)
        {
            _facade = facade;
        }

        public Bitmap Execute()
        {
            throw new NotImplementedException();
        }


        public Bitmap Unexecute()
        {
            throw new NotImplementedException();
        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
