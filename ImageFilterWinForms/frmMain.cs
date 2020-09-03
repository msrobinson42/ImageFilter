using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.BitmapFactories;
using ImageFilterLibrary.Facades;
using ImageFilterLibrary.FacadeFactory;
using ImageFilterLibrary.CommandFactory;
using ImageFilterLibrary;

namespace ImageFilterWinForms
{
    // TODO: Implement CommandFacadeFactory.
    // TODO: Find solution to Open/Closed problem with CommandFactory.
    public partial class ImageFilterView : Form
    {
        private readonly IBitmapFactory _bitmapFactory;
        private readonly ICommandFacadeFactory _commandFacadeFactory;
        private readonly ICommandFactory _commandFactory;
        private readonly Stack<IBitmapEffectCommand> _commandStack;
        private readonly Stack<Image> _bitmapStack = new Stack<Image>();
        private Image _image;
        private readonly ImageEditorState _state;

        private Action _lastCommand;

        public ImageFilterView(Stack<IBitmapEffectCommand> stack, BitmapFactory bitmapFactory, 
            ICommandFacadeFactory commandFacadeFactory, ICommandFactory commandFactory)
        {
            InitializeComponent();
            _bitmapFactory = bitmapFactory;
            _image = _bitmapFactory.GetInstance(picMain.Image);
            _commandStack = stack;
            _commandFacadeFactory = commandFacadeFactory;
            _commandFactory = commandFactory;

            _state = new ImageEditorState(_image);
        }

        private void UndoClick(object sender, EventArgs e)
        {
            try
            {
                _state.Undo();
                RefreshImageState();

                //if(_commandStack.Count > 0)
                //    _image.Dispose();

                //var command = _commandStack.Pop();
                //var result = _bitmapFactory.GetInstance(command.Unexecute());

                //var result = _bitmapStack.Pop();

                //RefreshImage(result);

                //command.Dispose();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You have not performed any actions yet.", "Empty Stack");
            }
        }

        private void RepeatClick(object sender, EventArgs e)
        {
            _lastCommand();

            RefreshImageState();
        }

        private void Rotate90CW(object sender, EventArgs e)
        {
            _state.Rotate90CW();
            _lastCommand = new Action(() => _state.Rotate90CW());

            RefreshImageState();
        }

        private void Rotate180(object sender, EventArgs e)
        {
            //_state.Rotate180();
            //_state.Rotate(180);
            _state.Brightness(50);
            _lastCommand = new Action(() => _state.Rotate180());

            RefreshImageState();
        }

        private void RefreshImageState()
        {
            picMain.Image = _state.Image;
        }

        private void MosaicClick(object sender, EventArgs e)
        {
            var radius = 80;

            _state.Test(radius);
            _lastCommand = new Action(() => _state.Test(radius));

            RefreshImageState();
            //ExecuteCommand(_commandFactory.GetInstance(_image, BitmapCommandType.Test));
        }

        private void ExecuteCommand(IBitmapEffectCommand command)
        {
            var result = command.Execute();

            _commandStack.Push(command);

            RefreshImage(result);
        }

        private void RefreshImage(Image image)
        {
            _image = image;
            picMain.Image = _image;
        }

        private void OpenImageClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;

                    //Create image and display it.
                    try
                    {
                        _image = _bitmapFactory.GetInstance(filePath);
                        picMain.Image = _image;
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Please submit a valid image file type.", "File not found");
                    }
                }
            }

            ResetStack();
        }

        private void ResetStack()
        {
            foreach (var item in _commandStack)
                item.Dispose();

            _commandStack.Clear();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _state.Redo();
            RefreshImageState();
        }
    }
}
