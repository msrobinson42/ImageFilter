using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.FacadeFactory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageFilterLibrary.CommandFactory
{
    public class CommandFactory : ICommandFactory
    {
        private readonly ICommandFacadeFactory _facadeFactory;

        public CommandFactory(ICommandFacadeFactory facadeFactory)
        {
            _facadeFactory = facadeFactory;
        }

        public IBitmapEffectCommand GetInstance(Bitmap image, BitmapCommandType type, params object[] variables)
        {
            var facade = _facadeFactory.GetInstance(image);

            //int? variable = variables.Any() ? variables[0] : null;

            switch(type)
            {
                //case BitmapCommandType.Blur:
                //    return new BlurCommand(facade, IFilter, bool);
                case BitmapCommandType.Test:
                    return new TestCommand(facade/*, (int)variable*/);
                case BitmapCommandType.Rotate90CW:
                    return new Rotate90ClockwiseCommand(image);
                case BitmapCommandType.Rotate90CCW:
                    return new Rotate90CounterClockwiseCommand(image);
                case BitmapCommandType.Rotate180:
                    return new Rotate180Command(image);
                case BitmapCommandType.Mosaic:
                    return new MosaicEffectCommand(image);
                case BitmapCommandType.Pixelate:
                    return new PixelateCommand(facade);
                case BitmapCommandType.Vignette:
                    return new VignetteCommand(facade);
                default:
                    throw new ArgumentException("No matching commands for given parameters.");

            }
        }

        // I want a new instance of <this> Command!
    }
}
