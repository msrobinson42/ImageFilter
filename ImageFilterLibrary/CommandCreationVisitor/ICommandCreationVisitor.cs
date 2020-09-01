using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary.CommandCreationVisitor
{
    public interface ICommandCreationVisitor
    {
        IBitmapEffectCommand Visit(TestCommandCreationInformation info);
    }
}
