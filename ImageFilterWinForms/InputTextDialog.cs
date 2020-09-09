using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Displays a runtime determined Dialog for
// image processing effects that require
// a single typed value from the user.
//Also handles related checkbox inputs
// for effects such as Hue.

namespace ImageFilterWinForms
{
    public partial class InputTextDialog : Form
    {
        private readonly int _max;
        private readonly int _min;

        /// <summary>
        /// Returns the resulting integer object from this dialog form.
        /// </summary>
        public int Result { get; private set; }

        /// <summary>
        /// Returns a boolean value determining whether Hue should be performed uniformly or as a rotation.
        /// </summary>
        public bool CheckboxResult { get; private set; }

        /// <summary>
        /// Creates a dialog form that will prompt the user for an integer object.
        /// </summary>
        /// <param name="title">The title of the dialog form.</param>
        /// <param name="prompt">The prompt that the user will read when filling out the dialog.</param>
        /// <param name="min">An optional parameter deciding the minimum value of a range.</param>
        /// <param name="max">An optional parameter deciding the maximum value of a range.</param>
        /// <param name="checkboxOption">An optional parameter deciding whether to prompt the user for the rotation property.</param>
        /// <param name="checkboxPrompt">An optional parameter that will name the optional checkbox.</param>
        public InputTextDialog(string title, string prompt, int min = -1000, int max = 1000,
            bool checkboxOption = false, string checkboxPrompt = "")
        {
            InitializeComponent();

            this.Text = title;
            lblPrompt.Text = prompt;

            _max = max;
            _min = min;

            chkOption.Visible = checkboxOption;
            chkOption.Text = checkboxPrompt;
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            var input = txtOutput.Text;
            if (IsValid(input))
            {
                Result = int.Parse(input);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, $"Please enter an integer value between {_min} and {_max}");
            }
        }

        private bool IsValid(string input) => int.TryParse(input, out int result) && IsWithinRange(result);

        private bool IsWithinRange(int value) => value >= _min && value <= _max;

        private void CheckboxChanged(object sender, EventArgs e) => CheckboxResult = chkOption.Checked;
    }
}
