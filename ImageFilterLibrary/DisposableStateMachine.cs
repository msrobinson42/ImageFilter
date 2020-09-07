using System;
using System.Collections.Generic;
using System.Linq;

namespace ImageFilterLibrary
{
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

        private void ClearRedoStack()
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
