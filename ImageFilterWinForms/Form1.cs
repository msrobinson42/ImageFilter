﻿using System;
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
                var oldCommand = _commandStack.Peek();
                var type = oldCommand.GetType();

                var command = (IBitmapEffectCommand)Activator.CreateInstance(type, _image);

                ExecuteCommand(command);
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

        private void ExecuteCommand(IBitmapEffectCommand cmd)
        {
            var result = cmd.Execute();

            _commandStack.Push(cmd);
            RefreshImage(result);
        }

        // not sure if we should mutate the image or create a new Bitmap after every effect.
        private void RefreshImage(Bitmap image)
        {
            //MessageBox.Show(image.Equals(_image).ToString());
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
