using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary.CommandCreationVisitor
{
    public class CommandCreationVisitor : ICommandCreationVisitor
    {
        public IBitmapEffectCommand Visit(TestCommandCreationInformation info)
        {
            return new TestCommand(info.Facade, info.Radius);
        }
    }
}
