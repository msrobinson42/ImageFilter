using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ImageFilterLibrary.EffectCommands;
using ImageFilterLibrary.BitmapFactories;
using ImageFilterLibrary.Facades;
using ImageFilterLibrary.FacadeFactory;

namespace ImageFilterWinForms
{
    // TODO: Implement CommandFacadeFactory.
    // TODO: Find solution to Open/Closed problem with CommandFactory.
    public partial class ImageFilterView : Form
    {
        private readonly IBitmapFactory _bitmapFactory;
        private readonly ICommandFacadeFactory _commandFacadeFactory;
        private readonly Stack<IBitmapEffectCommand> _commandStack;
        private Bitmap _image;

        public ImageFilterView(Stack<IBitmapEffectCommand> stack, BitmapFactory bitmapFactory, 
            ICommandFacadeFactory commandFacadeFactory)
        {
            InitializeComponent();
            _bitmapFactory = bitmapFactory;
            _image = _bitmapFactory.GetInstance(picMain.Image);
            _commandStack = stack;
            _commandFacadeFactory = commandFacadeFactory;
        }

        private void UndoClick(object sender, EventArgs e)
        {
            try
            {
                if(_commandStack.Count > 0)
                    _image.Dispose();

                var command = _commandStack.Pop();
                var result = _bitmapFactory.GetInstance(command.Unexecute());

                RefreshImage(result);

                command.Dispose();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You have not performed any actions yet.", "Empty Stack");
            }
        }

        private void RepeatClick(object sender, EventArgs e)
        {
            try
            {
                var oldCommand = _commandStack.Peek();
                var newCommand = oldCommand.NewCommandFromCopy(_image);

                ExecuteCommand(newCommand);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You have not performed any actions yet.", "Empty Stack");
            }
        }

        private void Rotate90CW(object sender, EventArgs e)
        {
            ExecuteCommand(new Rotate90ClockwiseCommand(_image));
        }

        private void Rotate180(object sender, EventArgs e)
        {
            ExecuteCommand(new Rotate180Command(_image));
        }

        private void MosaicClick(object sender, EventArgs e)
        {
            var facade = _commandFacadeFactory.GetInstance(_image);
            ExecuteCommand(new TestCommand(facade));
        }

        private void ExecuteCommand(IBitmapEffectCommand command)
        {
            var result = command.Execute();

            _commandStack.Push(command);

            RefreshImage(result);
        }

        private void RefreshImage(Bitmap image)
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
    }
}
