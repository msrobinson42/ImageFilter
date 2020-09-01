using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.Facades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary.CommandCreationVisitor
{
    public class TestCommandCreationInformation : ICommandCreationVisitee
    {
        public TestCommandCreationInformation(CommandFacade facade, int radius = 50)
        {
            Facade = facade;
            Radius = radius;
        }

        public CommandFacade Facade { get; }
        public int Radius { get; }

        public IBitmapEffectCommand Accept(ICommandCreationVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
