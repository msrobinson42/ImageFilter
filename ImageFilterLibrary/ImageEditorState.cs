using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageFilterLibrary
{
    public class ImageEditorState
    {
        private readonly ImageFactory _imageFactory = new ImageFactory();
        private readonly Stack<Bitmap> _undoStack = new Stack<Bitmap>();
        private readonly Stack<Bitmap> _redoStack = new Stack<Bitmap>();

        public ImageEditorState(Bitmap image)
        {
            Image = image;
        }

        public Bitmap Image { get; private set; }
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

        public void ClearRedoStack()
        {
            while(_redoStack.Count > 0)
            {
                var bmap = _redoStack.Pop();
                bmap.Dispose();
            }
        }

        public void Update(Bitmap newImage)
        {
            _undoStack.Push(Image);

            Image = newImage;

            ClearRedoStack();

        }
    }

    public class DisposableStateMachine<T> where T : IDisposable
    {
        private readonly Stack<T> _undoStack = new Stack<T>();
        private readonly Stack<T> _redoStack = new Stack<T>();

        public DisposableStateMachine(T state)
        {
            State = state;
        }

        public T State { get; private set; }
        public bool CanRedo => _redoStack.Any();
        public bool CanUndo => _undoStack.Any();

        public void Undo()
        {
            if (CanUndo)
            {
                _redoStack.Push(State);

                var result = _undoStack.Pop();

                State = result;
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                _undoStack.Push(State);

                var result = _redoStack.Pop();

                State = result;
            }
        }

        public void ClearRedoStack()
        {
            while (_redoStack.Count > 0)
            {
                var bmap = _redoStack.Pop();
                bmap.Dispose();
            }
        }

        public void Update(T newState)
        {
            _undoStack.Push(State);

            State = newState;

            ClearRedoStack();

        }
    }
}
