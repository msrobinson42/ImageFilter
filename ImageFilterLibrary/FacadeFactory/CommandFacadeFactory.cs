using ImageFilterLibrary.Facades;
using System.Drawing;

namespace ImageFilterLibrary.FacadeFactory
{
    public class CommandFacadeFactory : ICommandFacadeFactory
    {
        public CommandFacade GetInstance(Bitmap image)
        {
            return new CommandFacade(image);
        }
    }
}
