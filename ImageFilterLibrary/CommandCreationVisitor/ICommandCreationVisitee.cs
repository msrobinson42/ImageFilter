using ImageFilterLibrary.EffectCommands;

namespace ImageFilterLibrary.CommandCreationVisitor
{
    public interface ICommandCreationVisitee
    {
        IBitmapEffectCommand Accept(ICommandCreationVisitor visitor);
    }
}