namespace ImageFilterWinForms
{
    partial class ReplaceColorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBeforeColor = new System.Windows.Forms.PictureBox();
            this.picAfterColor = new System.Windows.Forms.PictureBox();
            this.btnBeforeColor = new System.Windows.Forms.Button();
            this.btnAfterColor = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblFuzziness = new System.Windows.Forms.Label();
            this.txtFuzziness = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBeforeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfterColor)).BeginInit();
            this.SuspendLayout();
            // 
            // picBeforeColor
            // 
            this.picBeforeColor.BackColor = System.Drawing.Color.Red;
            this.picBeforeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBeforeColor.Location = new System.Drawing.Point(29, 56);
            this.picBeforeColor.Name = "picBeforeColor";
            this.picBeforeColor.Size = new System.Drawing.Size(50, 50);
            this.picBeforeColor.TabIndex = 0;
            this.picBeforeColor.TabStop = false;
            this.picBeforeColor.Click += new System.EventHandler(this.BeforeColorClick);
            // 
            // picAfterColor
            // 
            this.picAfterColor.BackColor = System.Drawing.Color.Red;
            this.picAfterColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAfterColor.Location = new System.Drawing.Point(221, 56);
            this.picAfterColor.Name = "picAfterColor";
            this.picAfterColor.Size = new System.Drawing.Size(50, 50);
            this.picAfterColor.TabIndex = 1;
            this.picAfterColor.TabStop = false;
            this.picAfterColor.Click += new System.EventHandler(this.AfterColorclick);
            // 
            // btnBeforeColor
            // 
            this.btnBeforeColor.Location = new System.Drawing.Point(85, 69);
            this.btnBeforeColor.Name = "btnBeforeColor";
            this.btnBeforeColor.Size = new System.Drawing.Size(100, 25);
            this.btnBeforeColor.TabIndex = 2;
            this.btnBeforeColor.Text = "&Before Color";
            this.btnBeforeColor.UseVisualStyleBackColor = true;
            this.btnBeforeColor.Click += new System.EventHandler(this.BeforeColorClick);
            // 
            // btnAfterColor
            // 
            this.btnAfterColor.Location = new System.Drawing.Point(277, 69);
            this.btnAfterColor.Name = "btnAfterColor";
            this.btnAfterColor.Size = new System.Drawing.Size(100, 25);
            this.btnAfterColor.TabIndex = 3;
            this.btnAfterColor.Text = "&After Color";
            this.btnAfterColor.UseVisualStyleBackColor = true;
            this.btnAfterColor.Click += new System.EventHandler(this.AfterColorclick);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Location = new System.Drawing.Point(29, 19);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(348, 33);
            this.lblPrompt.TabIndex = 4;
            this.lblPrompt.Text = "label1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(307, 118);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(70, 25);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.ConfirmClick);
            // 
            // lblFuzziness
            // 
            this.lblFuzziness.AutoSize = true;
            this.lblFuzziness.Location = new System.Drawing.Point(29, 123);
            this.lblFuzziness.Name = "lblFuzziness";
            this.lblFuzziness.Size = new System.Drawing.Size(108, 15);
            this.lblFuzziness.TabIndex = 6;
            this.lblFuzziness.Text = "Fuzziness (0 - 128) :";
            // 
            // txtFuzziness
            // 
            this.txtFuzziness.Location = new System.Drawing.Point(143, 119);
            this.txtFuzziness.MaxLength = 3;
            this.txtFuzziness.Name = "txtFuzziness";
            this.txtFuzziness.Size = new System.Drawing.Size(67, 23);
            this.txtFuzziness.TabIndex = 7;
            // 
            // ReplaceColorDialog
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 172);
            this.Controls.Add(this.txtFuzziness);
            this.Controls.Add(this.lblFuzziness);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnAfterColor);
            this.Controls.Add(this.btnBeforeColor);
            this.Controls.Add(this.picAfterColor);
            this.Controls.Add(this.picBeforeColor);
            this.Name = "ReplaceColorDialog";
            this.Text = "ReplaceColorDialog";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.picBeforeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfterColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBeforeColor;
        private System.Windows.Forms.PictureBox picAfterColor;
        private System.Windows.Forms.Button btnBeforeColor;
        private System.Windows.Forms.Button btnAfterColor;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblFuzziness;
        private System.Windows.Forms.TextBox txtFuzziness;
    }
}