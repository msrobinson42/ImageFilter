using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ImageFilterLibrary;

namespace ImageFilterWinForms
{
    public partial class ImageFilterView : Form
    {
        private ImageEditorState _state;
        private Action _lastCommand;

        public ImageFilterView()
        {
            InitializeComponent();

            _state = new ImageEditorState(picMain.Image);
        }

        private void RefreshImageState() => picMain.Image = _state.Image;

        private void UndoClick(object sender, EventArgs e)
        {
            _state.Undo();
            RefreshImageState();
        }

        private void RepeatClick(object sender, EventArgs e)
        {
            _lastCommand?.Invoke();

            RefreshImageState();
        }

        private void Rotate90CW(object sender, EventArgs e)
        {
            int degrees = 90;

            _state.Rotate(degrees);
            _lastCommand = new Action(() => _state.Rotate(degrees));

            RefreshImageState();
        }

        private void Rotate180(object sender, EventArgs e)
        {
            int degrees = 180;

            _state.Rotate(degrees);
            _lastCommand = new Action(() => _state.Rotate(degrees));

            RefreshImageState();
        }

        private void TestClick(object sender, EventArgs e)
        {
            var radius = 80;

            _state.Test(radius);
            _lastCommand = new Action(() => _state.Test(radius));

            RefreshImageState();
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
                        var image = new Bitmap(filePath);
                        _state = new ImageEditorState(image);
                        RefreshImageState();
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

        private void RedoClick(object sender, EventArgs e)
        {
            _state.Redo();
            RefreshImageState();
        }
    }
}
