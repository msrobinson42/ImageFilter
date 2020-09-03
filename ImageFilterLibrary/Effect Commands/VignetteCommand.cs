using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.Facades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
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
            var imgAfterFilter = _facade.ImageFactory
                 .Vignette(_color)
                 .Image;

            return _facade.BitmapFactory.GetInstance(imgAfterFilter);
        }

        public Bitmap Unexecute()
        {
            return _facade.InitialImage;

        }

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            var facade = _facade.Copy(image);
            return new VignetteCommand(facade);

        }

        public void Dispose()
        {
            _facade.InitialImage.Dispose();
            _facade.ImageFactory.Dispose();

        }
    }
}
