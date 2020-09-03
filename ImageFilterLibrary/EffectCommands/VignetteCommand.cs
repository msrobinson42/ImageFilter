using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.Facades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.EffectCommands
{
    public class VignetteCommand : IBitmapEffectCommand
    {
        //TODO: Leila - Finish this class.
        private readonly CommandFacade _facade;
        private readonly Color? _color;

        public VignetteCommand(CommandFacade facade, Color? color = null)
        {
            _facade = facade;
            _color = color;
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
