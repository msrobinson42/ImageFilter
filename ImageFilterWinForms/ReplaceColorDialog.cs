using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageFilterWinForms
{
    public partial class ReplaceColorDialog : Form
    {
        public Color TargetColor { get; private set; }
        public Color ReplacementColor { get; private set; }
        public int Fuzziness { get; private set; }

        public ReplaceColorDialog(string title, string prompt)
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            return TargetColor != null 
                   && ReplacementColor != null
                   && int.TryParse(txtFuzziness.Text, out _);
        }

        private void BeforeColorClick(object sender, EventArgs e)
        {
            using var colorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                FullOpen = true,
                AnyColor = true,
                ShowHelp = true
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                TargetColor = colorDialog.Color;
                picBeforeColor.BackColor = TargetColor;
            }
        }

        private void AfterColorclick(object sender, EventArgs e)
        {
            using var colorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                FullOpen = true,
                AnyColor = true,
                ShowHelp = true
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ReplacementColor = colorDialog.Color;
                picAfterColor.BackColor = ReplacementColor;
            }
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            if(IsValid())
            {
                Fuzziness = int.Parse(txtFuzziness.Text);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please double check and enter valid inputs into the controls.", "Error");
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            TargetColor = picBeforeColor.BackColor;
            ReplacementColor = picAfterColor.BackColor;
        }
    }
}
