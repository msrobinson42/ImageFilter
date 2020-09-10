using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Displays a unique Dialog for the
// Replace Color effect.
//A general runtime solution could
// not be easily implemented.

namespace ImageFilterWinForms
{
    public partial class ReplaceColorDialog : Form
    {
        /// <summary>
        /// Returns the Target Color for the ReplaceColor() method.
        /// </summary>
        public Color TargetColor { get; private set; }

        /// <summary>
        /// Returns the Replacement Color for the ReplaceColor() method.
        /// </summary>
        public Color ReplacementColor { get; private set; }

        /// <summary>
        /// Returns the amount of fuzziness for the ReplaceColor() method.
        /// </summary>
        public int Fuzziness { get; private set; }

        /// <summary>
        /// Creates a form that will prompt the user for all applicable properties for use in the ReplaceColor() process.
        /// </summary>
        /// <param name="title">The title of this particular dialog form.</param>
        /// <param name="prompt">The prompt that the user will read when filling out the dialog.</param>
        public ReplaceColorDialog(string title, string prompt)
        {
            InitializeComponent();

            this.Text = title;
            lblPrompt.Text = prompt;
        }

        private bool IsValid()
        {
            return TargetColor != null 
                   && ReplacementColor != null
                   && int.TryParse(txtFuzziness.Text, out int fuzziness)
                   && IsWithinRange(fuzziness);
        }

        private bool IsWithinRange(int fuzziness)
        {
            return fuzziness >= 0 && fuzziness <= 128;
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
                txtFuzziness.Focus();
                txtFuzziness.SelectAll();
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            TargetColor = picBeforeColor.BackColor;
            ReplacementColor = picAfterColor.BackColor;
        }
    }
}
