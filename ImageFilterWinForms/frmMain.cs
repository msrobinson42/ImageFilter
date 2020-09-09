using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ImageFilterLibrary;
using ImageProcessor.Imaging.Filters.EdgeDetection;
using ImageProcessor.Imaging.Filters.Photo;

//The Winforms View for the application.
//Holds click event handlers for all photo-manipulation effects
// as well as baseline Open/Save/Close and Undo/Redo functionality.

namespace ImageFilterWinForms
{
    public partial class ImageFilterView : Form
    {
        private ImageEditorState _state;
        private Action _lastCommand;

        /// <summary>
        /// Creates the main window for the Image Filter application.
        /// </summary>
        public ImageFilterView()
        {
            InitializeComponent();

            _state = new ImageEditorState(picMain.Image);
        }

        private void RefreshImageState() => picMain.Image = _state.Image;

        #region File ClickEvents

        private void OpenImageClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"c:\",
                Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

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
            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Image Files(*.JPG;*.BMP;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _state.Image.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Edit ClickEvents

        private void UndoClick(object sender, EventArgs e)
        {
            _state.Undo();
            RefreshImageState();
        }

        private void RedoClick(object sender, EventArgs e)
        {
            _state.Redo();
            RefreshImageState();
        }

        private void RepeatClick(object sender, EventArgs e)
        {
            _lastCommand?.Invoke();

            RefreshImageState();
        }

        #endregion

        #region Tools ClickEvents

        private void Rotate(object sender, EventArgs e)
        {
            using var rotateDialog = new InputTextDialog("Rotate", "The angle at which to rotate the image:");

            if (rotateDialog.ShowDialog() == DialogResult.OK)
            {
                var degrees = rotateDialog.Result;

                _state.Rotate(degrees);
                _lastCommand = new Action(() => _state.Rotate(degrees));
            }

            RefreshImageState();
        }

        private void Alpha(object sender, EventArgs e) 
        {
            using var alphaDialog = new InputTextDialog(
                "Alpha", "The percentage (0 to 100) by which to alter the image's opacity:",
                    0, 100);

            if(alphaDialog.ShowDialog() == DialogResult.OK)
            {
                var percentage = alphaDialog.Result;

                _state.Alpha(percentage);
                _lastCommand = new Action(() => _state.Alpha(percentage));
            }

            RefreshImageState();
        }

        private void BackgroundColor(object sender, EventArgs e) 
        {
            using var colorDialog = new InputColorDialog(
                "Background Color", "The color to paint the background with:");

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                var color = colorDialog.ColorResult;

                _state.BackgroundColor(color);
                _lastCommand = new Action(() => _state.BackgroundColor(color));
            }

            RefreshImageState();
        }

        private void Brightness(object sender, EventArgs e) 
        {
            using var brightnessDialog = new InputTextDialog(
                "Brightness", "The percentage (-100 to 100) by which to alter the image's brightness:", 
                    -100, 100);

            if(brightnessDialog.ShowDialog() == DialogResult.OK)
            {
                var percentage = brightnessDialog.Result;

                _state.Brightness(percentage);
                _lastCommand = new Action(() => _state.Brightness(percentage));
            }

            RefreshImageState();
        }
        
        private void DetectEdges(object sender, EventArgs e) 
        {
            var options = Resources.EdgeFilters;

            using var edgesDialog = new InputDropdownDialog<IEdgeFilter>(
                "Detect Edges", "The algorithm to detect edges with:",
                options, true);

            if(edgesDialog.ShowDialog() == DialogResult.OK)
            {
                var filter = edgesDialog.Result;
                var greyscale = edgesDialog.CheckboxResult;

                _state.DetectEdges(filter, greyscale);
                _lastCommand = new Action(() => _state.DetectEdges(filter, greyscale));
            }

            RefreshImageState();
        }

        private void Filter(object sender, EventArgs e) 
        {
            var options = Resources.PhotoFilters;

            using var filterDialog = new InputDropdownDialog<IMatrixFilter>(
                "Photo Filter", "The filter to be applied to the image:", options);

            if(filterDialog.ShowDialog() == DialogResult.OK)
            {
                var filter = filterDialog.Result;

                _state.Filter(filter);
                _lastCommand = new Action(() => _state.Filter(filter));
            }

            RefreshImageState();
        }

        //TODO: Large Performance Calculation
        private void GaussianBlur(object sender, EventArgs e) 
        {
            using var blurDialog = new InputTextDialog(
                "Gaussian Blur", "The size of the kernel by which to blur the image:", 0);

            if(blurDialog.ShowDialog() == DialogResult.OK)
            {
                int size = blurDialog.Result;

                _state.GaussianBlur(size);
                _lastCommand = new Action(() => _state.GaussianBlur(size));
            }

            RefreshImageState();
        }

        //TODO: Large Performance Calculation
        private void GaussianSharpen(object sender, EventArgs e) 
        {
            using var sharpenDialog = new InputTextDialog(
                "Gaussian Sharpen", "The size of the kernel by which to sharpen the image:", 0);
            
            if(sharpenDialog.ShowDialog() == DialogResult.OK)
            {
                int size = sharpenDialog.Result;

                _state.GaussianSharpen(size);
                _lastCommand = new Action(() => _state.GaussianSharpen(size));
            }

            RefreshImageState();
        }

        private void Hue(object sender, EventArgs e) 
        {
            using var hueDialog = new InputTextDialog(
                "Hue", "The angle (0 - 360) by which to alter the image's hue.",
                0, 360, true, "Rotate");

            if(hueDialog.ShowDialog() == DialogResult.OK)
            {
                var degrees = hueDialog.Result;
                var rotate = hueDialog.CheckboxResult;

                _state.Hue(degrees, rotate);
                _lastCommand = new Action(() => _state.Hue(degrees, rotate));
            }

            RefreshImageState();
        }

        private void Pixelate(object sender, EventArgs e) 
        {
            using var pixelateDialog = new InputTextDialog(
                "Pixelate", "The size of the pixels to create:", 0);

            if(pixelateDialog.ShowDialog() == DialogResult.OK)
            {
                int size = pixelateDialog.Result;

                _state.Pixelate(size);
                _lastCommand = new Action(() => _state.Pixelate(size));
            }

            RefreshImageState();
        }

        private void ReplaceColor(object sender, EventArgs e) 
        {
            using var replaceColorDialog = new ReplaceColorDialog(
                "Replace Color", 
                "Replaces a target color (before) with a replacement color (after) with some amount of fuzziness:");

            if(replaceColorDialog.ShowDialog() == DialogResult.OK)
            {
                var target = replaceColorDialog.TargetColor;
                var replacement = replaceColorDialog.ReplacementColor;
                var fuzziness = replaceColorDialog.Fuzziness;

                _state.ReplaceColor(target, replacement, fuzziness);
                _lastCommand = new Action(() => _state.ReplaceColor(target, replacement, fuzziness));
            }

            RefreshImageState();
        }

        private void RoundedCorners(object sender, EventArgs e) 
        {
            using var cornersDialog = new InputTextDialog(
                "Rounded Corners", "The radius at which the corner will be rounded:", 1);

            if(cornersDialog.ShowDialog() == DialogResult.OK)
            {
                int radius = cornersDialog.Result;

                _state.RoundedCorners(radius);
                _lastCommand = new Action(() => _state.RoundedCorners(radius));
            }

            RefreshImageState();
        }

        private void Saturation(object sender, EventArgs e) 
        {
            using var saturationDialog = new InputTextDialog(
                "Saturation", "The percentage (-100 to 100) by which to alter the image's saturation.", -100, 100);

            if(saturationDialog.ShowDialog() == DialogResult.OK)
            {
                int percentage = saturationDialog.Result;

                _state.Saturation(percentage);
                _lastCommand = new Action(() => _state.Saturation(percentage));
            }

            RefreshImageState();
        }

        private void Tint(object sender, EventArgs e) 
        {
            using var tintDialog = new InputColorDialog(
                "Tint", "The color to tint the image with:");

            if (tintDialog.ShowDialog() == DialogResult.OK)
            {
                var color = tintDialog.ColorResult;

                _state.Tint(color);
                _lastCommand = new Action(() => _state.Tint(color));
            }

            RefreshImageState();
        }

        private void Vignette(object sender, EventArgs e) 
        {
            using var vignetteDialog = new InputColorDialog(
                "Vignette", "The color to vignette the image with:");

            if (vignetteDialog.ShowDialog() == DialogResult.OK)
            {
                var color = vignetteDialog.ColorResult;

                _state.Vignette(color);
                _lastCommand = new Action(() => _state.Vignette(color));
            }

            RefreshImageState();
        }

        #endregion


    }
}
