using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.Facades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
{ 
  
   public class AlphaCommand : IBitmapEffectCommand

    {
        private readonly CommandFacade _facade;
        private readonly int _percentage;

        public AlphaCommand(CommandFacade facade, int percentage = 50)
        {
            _facade = facade;
            _percentage = percentage;
        }

        public Bitmap Execute()
        { 
            var imgAfterFilter = _facade.ImageFactory
                .Alpha(_percentage)
                .Image;

            return _facade.BitmapFactory.GetInstance(imgAfterFilter);
        }

        public void Dispose()
        {
            _facade.InitialImage.Dispose();
            _facade.ImageFactory.Dispose();
        }

     

        public IBitmapEffectCommand NewCommandFromCopy(Bitmap image)
        {
            var facade = _facade.Copy(image);
            return new AlphaCommand(facade);
        }

        public Bitmap Unexecute()
        {
            return _facade.InitialImage;
        }
    }
}
