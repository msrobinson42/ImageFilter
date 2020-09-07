using ImageProcessor;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageFilterLibrary
{
    public class ImageEditorState
    {
        private readonly Stack<Image> _undoStack = new Stack<Image>();
        private readonly Stack<Image> _redoStack = new Stack<Image>();

        public ImageEditorState(Image image)
        {
            Image = image;
        }

        public Image Image { get; private set; }
        public ImageFactory ImageFactory { get; }
        public bool CanRedo => _redoStack.Any();
        public bool CanUndo => _undoStack.Any();

        public void Undo()
        {
            if (CanUndo)
            {
                _redoStack.Push(Image);

                var result = _undoStack.Pop();

                Image = result; 
            }
        }

        public void Redo()
        {
            if(CanRedo) 
            { 
                _undoStack.Push(Image);

                var result = _redoStack.Pop();

                Image = result;
            }
        }

        private void ClearRedoStack()
        {
            while(_redoStack.Count > 0)
            {
                var bmap = _redoStack.Pop();
                bmap.Dispose();
            }
        }

        public void Update(Image newImage)
        {
            _undoStack.Push(Image);

            Image = newImage;

            ClearRedoStack();
        }
    }
}
