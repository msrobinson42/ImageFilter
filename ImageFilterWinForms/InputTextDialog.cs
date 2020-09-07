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
        public int Result { get; private set; }

        public InputTextDialog(string title, string prompt)
        {
            InitializeComponent();

            this.Text = title;
            lblPrompt.Text = prompt;
        }

        private void GetResult()
        {
            int.TryParse(txtOutput.Text, out int result);
            Result = result;
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            GetResult();
            ExitClick(sender, e);
        }

        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
