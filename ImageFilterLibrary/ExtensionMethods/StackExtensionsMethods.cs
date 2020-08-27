using System;
using ImageFilterLibrary.EffectCommands;
using System.Collections.Generic;
using System.Drawing;

namespace ImageFilterWinForms
{
    public static class StackExtensionsMethods
    {
        public static Bitmap UndoPop(this Stack<IBitmapEffectCommand> @this)
        {
            if (@this.Count == 0)
                throw new InvalidOperationException("The stack is empty");

            var command = @this.Peek();
            @this.Pop();

            return command.Unexecute();
        }
    }
}
