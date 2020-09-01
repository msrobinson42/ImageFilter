using ImageFilterLibrary.Facades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.FacadeFactory
{
    public interface ICommandFacadeFactory
    {
        public CommandFacade GetInstance(Bitmap image);
    }
}
