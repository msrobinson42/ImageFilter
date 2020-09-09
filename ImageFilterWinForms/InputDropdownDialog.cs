using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageFilterWinForms
{
    public partial class InputDropdownDialog<T> : Form
    {
        private readonly List<T> _options;

        /// <summary>
        /// Returns the resulting generic filter object from this dialog form.
        /// </summary>
        public T Result { get; private set; }

        /// <summary>
        /// Returns a boolean deciding whether or not to perform a greyscale manipulation.
        /// </summary>
        public bool CheckboxResult { get; private set; } = false;

        /// <summary>
        /// Creates a dialog form that will prompt the user for a generic filter object.
        /// </summary>
        /// <param name="title">The title of the dialog form.</param>
        /// <param name="prompt">The prompt that the user will read when filling out the form.</param>
        /// <param name="options">A generic list that the user will choose from.</param>
        /// <param name="greyscale">An optional parameter for deciding if the subsequent manipulation should be in greyscale.</param>
        public InputDropdownDialog(string title, string prompt, List<T> options, bool greyscale = false)
        {
            InitializeComponent();

            this.Text = title;
            lblPrompt.Text = prompt;
            _options = options;

            chkGreyscale.Visible = greyscale;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            foreach (var option in _options)
            {
                if (option is string)
                    cboOptions.Items.Add(option);
                else
                    cboOptions.Items.Add(option.GetType().Name);
            }

            cboOptions.SelectedIndex = 0;
            Result = _options[0];
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cboOptions.SelectedIndex;
            Result = _options[index];
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            if (Result != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckboxResult = chkGreyscale.Checked;
        }
    }
}
