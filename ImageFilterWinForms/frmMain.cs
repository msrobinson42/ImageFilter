using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ImageFilterLibrary;

/* TODO:
 * ALPHA
 * BACKGROUND_COLOR
 * BRIGHTNESS
 * --CONSTRAIN
 * CONTRAST
 * DETECT_EDGES
 * ENTROPY_CROP
 * FILTER
 * --FORMAT
 * GAUSSIAN_BLUR
 * GAUSSIAN_SHARPEN
 * HUE
 * PIXELATE
 * QUALITY
 * REPLACE_COLOR
 * ROTATE
 * ROUNDED_CORNERS
 * SATURATION
 * TINT
 * VIGNETTE
 */
    
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

        private void Rotate(object sender, EventArgs e)
        {
            using var rotateDialog = new InputTextDialog("Rotate", "Angle of rotation in degrees:");

            if (rotateDialog.ShowDialog() == DialogResult.OK)
            {
                var degrees = rotateDialog.Result;

                _state.Rotate(degrees);
                _lastCommand = new Action(() => _state.Rotate(degrees));
            }

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
            using OpenFileDialog openFileDialog = new OpenFileDialog();
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

        private void SaveImageClick(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files(*.JPG;*.BMP;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _state.Image.Save(dialog.FileName, ImageFormat.Jpeg);
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
