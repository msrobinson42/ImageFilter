using System;
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
            var image = picMain.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picMain.Image = image;
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
