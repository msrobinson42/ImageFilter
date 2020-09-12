using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Displays a runtime determined Dialog for
// image processing effects that require
// a single color input from the user.
//Zach

namespace ImageFilterWinForms
{
    public partial class InputColorDialog : Form
    {
        /// <summary>
        /// Returns the resulting Color object from this dialog form.
        /// </summary>
        public Color ColorResult { get; private set; } = Color.Red;

        /// <summary>
        /// Creates a dialog form that will prompt the user for a Color object.
        /// </summary>
        /// <param name="title">The title of this particular dialog instance.</param>
        /// <param name="prompt">The prompt that the user will read when filling out the dialog.</param>
        public InputColorDialog(string title, string prompt)
        {
            InitializeComponent();

            this.Text = title;
            lblPrompt.Text = prompt;

        }

        private void PickColorClick(object sender, EventArgs e)
        {
            using var colorDialog = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true,
                AnyColor = true,
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorResult = colorDialog.Color;
                picColor.BackColor = ColorResult;
            }
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
