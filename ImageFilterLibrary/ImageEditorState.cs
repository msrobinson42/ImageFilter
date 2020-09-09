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

        /// <summary>
        /// A state machine for holding any given state for the image that is being processed.
        /// </summary>
        /// <param name="image">The original image to be passed in for processing.</param>
        public ImageEditorState(Image image)
        {
            Image = image;
        }

        /// <summary>
        /// The current state of the Image.
        /// </summary>
        public Image Image { get; private set; }

        private bool CanRedo => _redoStack.Any();
        private bool CanUndo => _undoStack.Any();

        /// <summary>
        /// Reverts the state of the image a single step if able.
        /// </summary>
        public void Undo()
        {
            if (CanUndo)
            {
                _redoStack.Push(Image);

                var result = _undoStack.Pop();

                Image = result; 
            }
        }

        /// <summary>
        /// Steps the state of the image forward if able. 
        /// Intended to 'undo' an Undo() method call.
        /// </summary>
        public void Redo()
        {
            if(CanRedo) 
            { 
                _undoStack.Push(Image);

                var result = _redoStack.Pop();

                Image = result;
            }
        }

        /// <summary>
        /// Clears the Redo stack.
        /// </summary>
        private void ClearRedoStack()
        {
            while(_redoStack.Count > 0)
            {
                var bmap = _redoStack.Pop();
                bmap.Dispose();
            }
        }

        /// <summary>
        /// Updates the current state of the Image.
        /// </summary>
        /// <param name="newImage">The image with which to update the state.</param>
        public void Update(Image newImage)
        {
            _undoStack.Push(Image);

            Image = newImage;

            ClearRedoStack();
        }
    }
}
