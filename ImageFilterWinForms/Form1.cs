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

namespace ImageFilterWinForms
{
    public partial class ImageFilterView : Form
    {
        private Bitmap _image;

        public ImageFilterView()
        {
            InitializeComponent();
            _image = new Bitmap(picMain.Image);
        }

        private void Rotate(object sender, EventArgs e)
        {
            var command = new Rotate90ClockwiseCommand(_image);
            var result = command.Execute();
            RefreshImage(result);
        }

        //
        // not sure if I should mutate the image or create a new Bitmap after every effect.
        //
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
                        MessageBox.Show("Please submit a valid image file type.");
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
