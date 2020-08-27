using System;
using ImageFilterLibrary.Effect_Commands;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageFilterLibrary.EffectCommands;

namespace ImageFilterWinForms
{
    public partial class ImageFilterView : Form
    {
        private Bitmap _image;
        private Stack<IBitmapEffectCommand> _commandStack;

        public ImageFilterView(Stack<IBitmapEffectCommand> stack)
        {
            InitializeComponent();
            _image = new Bitmap(picMain.Image);
            _commandStack = stack;
        }

        private void UndoClick(object sender, EventArgs e)
        {
            try
            {
                var result = _commandStack.UndoPop();

                RefreshImage(result);
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
                var command = _commandStack.Peek();
                var result = command.Execute();

                //If we want command to be added to stack.
                _commandStack.Push(command);

                RefreshImage(result);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You have not performed any actions yet.", "Empty Stack");
            }
        }

        private void Rotate90CW(object sender, EventArgs e)
        {
            // var command = new Rotate90ClockwiseCommand(_image);
            var command = new Rotate90CounterClockwiseCommand(_image);
            var result = command.Execute();

            _commandStack.Push(command);
            RefreshImage(result);
        }

        // not sure if we should mutate the image or create a new Bitmap after every effect.
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
                        _image = new Bitmap(filePath);
                        picMain.Image = _image;
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Please submit a valid image file type.", "File not found");
                    }
                }
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
