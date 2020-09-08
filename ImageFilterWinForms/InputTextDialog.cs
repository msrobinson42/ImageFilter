using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageFilterWinForms
{
    public partial class InputTextDialog : Form
    {
        private readonly int _max;
        private readonly int _min;

        public int Result { get; private set; }
        public bool CheckboxResult { get; private set; }

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
                ExitClick(sender, e);
            }
            else
            {
                MessageBox.Show(this, $"Please enter an integer value between {_min} and {_max}");
            }
        }

        private bool IsValid(string input) => int.TryParse(input, out int result) && IsWithinRange(result);

        private bool IsWithinRange(int value) => value >= _min && value <= _max;

        private void ExitClick(object sender, EventArgs e) => this.Close();

        private void CheckboxChanged(object sender, EventArgs e) => CheckboxResult = chkOption.Checked;
    }
}
