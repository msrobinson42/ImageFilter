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

        public InputTextDialog(string title, string prompt, int min = -1000, int max = 1000)
        {
            InitializeComponent();

            this.Text = title;
            lblPrompt.Text = prompt;

            _max = max;
            _min = min;
        }     

        private void GetResult()
        {
            int.TryParse(txtOutput.Text, out int result);
            Result = result;
        }

        private bool IsWithinRange(int value)
        {
            return value >= _min && value <= _max;
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            GetResult();
            if (IsWithinRange(Result))
            {
                this.DialogResult = DialogResult.OK;
                ExitClick(sender, e);
            }
            else
            {
                MessageBox.Show(this, $"Please enter a value between {_min} and {_max}");
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
