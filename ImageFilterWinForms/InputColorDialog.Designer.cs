namespace ImageFilterWinForms
{
    partial class InputColorDialog
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.btnPickColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(498, 38);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 25);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "C&onfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.ConfirmClick);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Location = new System.Drawing.Point(41, 25);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(395, 50);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "label1";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.Red;
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColor.Location = new System.Drawing.Point(442, 18);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(50, 50);
            this.picColor.TabIndex = 3;
            this.picColor.TabStop = false;
            this.picColor.Click += new System.EventHandler(this.PickColorClick);
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(442, 74);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(50, 25);
            this.btnPickColor.TabIndex = 4;
            this.btnPickColor.Text = "&Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.PickColorClick);
            // 
            // InputColorDialog
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 111);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnPickColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputColorDialog";
            this.Text = "InputColorDialog";
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Button btnPickColor;
    }
}