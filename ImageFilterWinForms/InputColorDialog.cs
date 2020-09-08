using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageFilterWinForms
{
    public partial class InputColorDialog : Form
    {
        public Color ColorResult { get; private set; } = Color.Red;

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
                ShowHelp = true
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
