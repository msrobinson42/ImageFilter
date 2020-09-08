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

        public T Result { get; private set; }
        public bool CheckboxResult { get; private set; } = false;

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
