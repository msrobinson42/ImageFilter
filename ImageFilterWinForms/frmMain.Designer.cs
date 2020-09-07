using System;
using System.Windows.Forms;

namespace ImageFilterWinForms
{
    partial class ImageFilterView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageFilterView));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectEdgesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entropyCropMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussBlurMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussSharpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cornersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vignetteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMain.BackColor = System.Drawing.Color.Black;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 27);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(850, 436);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(850, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenImageClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveImageClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.repeatToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoClick);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.repeatToolStripMenuItem.Text = "Repeat Last Action";
            this.repeatToolStripMenuItem.Click += new System.EventHandler(this.RepeatClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateStripMenuItem,
            this.alphaMenuItem,
            this.bgColorMenuItem,
            this.brightnessMenuItem,
            this.detectEdgesMenuItem,
            this.entropyCropMenuItem,
            this.filterMenuItem,
            this.gaussBlurMenuItem,
            this.gaussSharpenMenuItem,
            this.hueMenuItem,
            this.pixelateMenuItem,
            this.qualityMenuItem,
            this.replaceColorMenuItem,
            this.cornersMenuItem,
            this.saturationMenuItem,
            this.tintMenuItem,
            this.vignetteMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // rotateStripMenuItem
            // 
            this.rotateStripMenuItem.Name = "rotateStripMenuItem";
            this.rotateStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.rotateStripMenuItem.Text = "Rotate";
            this.rotateStripMenuItem.Click += new System.EventHandler(this.Rotate);
            // 
            // alphaMenuItem
            // 
            this.alphaMenuItem.Name = "alphaMenuItem";
            this.alphaMenuItem.Size = new System.Drawing.Size(170, 22);
            this.alphaMenuItem.Text = "Alpha";
            this.alphaMenuItem.Click += new System.EventHandler(this.Alpha);
            // 
            // bgColorMenuItem
            // 
            this.bgColorMenuItem.Name = "bgColorMenuItem";
            this.bgColorMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bgColorMenuItem.Text = "Background Color";
            this.bgColorMenuItem.Click += new System.EventHandler(this.BackgroundColor);
            // 
            // brightnessMenuItem
            // 
            this.brightnessMenuItem.Name = "brightnessMenuItem";
            this.brightnessMenuItem.Size = new System.Drawing.Size(170, 22);
            this.brightnessMenuItem.Text = "Brightness";
            this.brightnessMenuItem.Click += new System.EventHandler(this.Brightness);
            // 
            // detectEdgesMenuItem
            // 
            this.detectEdgesMenuItem.Name = "detectEdgesMenuItem";
            this.detectEdgesMenuItem.Size = new System.Drawing.Size(170, 22);
            this.detectEdgesMenuItem.Text = "Detect Edges";
            this.detectEdgesMenuItem.Click += new System.EventHandler(this.DetectEdges);
            // 
            // entropyCropMenuItem
            // 
            this.entropyCropMenuItem.Name = "entropyCropMenuItem";
            this.entropyCropMenuItem.Size = new System.Drawing.Size(170, 22);
            this.entropyCropMenuItem.Text = "Entropy Crop";
            this.entropyCropMenuItem.Click += new System.EventHandler(this.EntropyCrop);
            // 
            // filterMenuItem
            // 
            this.filterMenuItem.Name = "filterMenuItem";
            this.filterMenuItem.Size = new System.Drawing.Size(170, 22);
            this.filterMenuItem.Text = "Filter";
            this.filterMenuItem.Click += new System.EventHandler(this.Filter);
            // 
            // gaussBlurMenuItem
            // 
            this.gaussBlurMenuItem.Name = "gaussBlurMenuItem";
            this.gaussBlurMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gaussBlurMenuItem.Text = "Gaussian Blur";
            this.gaussBlurMenuItem.Click += new System.EventHandler(this.GaussianBlur);
            // 
            // gaussSharpenMenuItem
            // 
            this.gaussSharpenMenuItem.Name = "gaussSharpenMenuItem";
            this.gaussSharpenMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gaussSharpenMenuItem.Text = "Gaussian Sharpen";
            this.gaussSharpenMenuItem.Click += new System.EventHandler(this.GaussianSharpen);
            // 
            // hueMenuItem
            // 
            this.hueMenuItem.Name = "hueMenuItem";
            this.hueMenuItem.Size = new System.Drawing.Size(170, 22);
            this.hueMenuItem.Text = "Hue";
            this.hueMenuItem.Click += new System.EventHandler(this.Hue);
            // 
            // pixelateMenuItem
            // 
            this.pixelateMenuItem.Name = "pixelateMenuItem";
            this.pixelateMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pixelateMenuItem.Text = "Pixelate";
            this.pixelateMenuItem.Click += new System.EventHandler(this.Pixelate);
            // 
            // qualityMenuItem
            // 
            this.qualityMenuItem.Name = "qualityMenuItem";
            this.qualityMenuItem.Size = new System.Drawing.Size(170, 22);
            this.qualityMenuItem.Text = "Quality";
            this.qualityMenuItem.Click += new System.EventHandler(this.Quality);
            // 
            // replaceColorMenuItem
            // 
            this.replaceColorMenuItem.Name = "replaceColorMenuItem";
            this.replaceColorMenuItem.Size = new System.Drawing.Size(170, 22);
            this.replaceColorMenuItem.Text = "Replace Color";
            this.replaceColorMenuItem.Click += new System.EventHandler(this.ReplaceColor);
            // 
            // cornersMenuItem
            // 
            this.cornersMenuItem.Name = "cornersMenuItem";
            this.cornersMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cornersMenuItem.Text = "Rounded Corners";
            this.cornersMenuItem.Click += new System.EventHandler(this.RoundedCorners);
            // 
            // saturationMenuItem
            // 
            this.saturationMenuItem.Name = "saturationMenuItem";
            this.saturationMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saturationMenuItem.Text = "Saturation";
            this.saturationMenuItem.Click += new System.EventHandler(this.Saturation);
            // 
            // tintMenuItem
            // 
            this.tintMenuItem.Name = "tintMenuItem";
            this.tintMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tintMenuItem.Text = "Tint";
            this.tintMenuItem.Click += new System.EventHandler(this.Tint);
            // 
            // vignetteMenuItem
            // 
            this.vignetteMenuItem.Name = "vignetteMenuItem";
            this.vignetteMenuItem.Size = new System.Drawing.Size(170, 22);
            this.vignetteMenuItem.Text = "Vignette";
            this.vignetteMenuItem.Click += new System.EventHandler(this.Vignette);
            // 
            // ImageFilterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 461);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.picMain);
            this.Name = "ImageFilterView";
            this.Text = "Image Filter";
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private MenuStrip mnuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem rotateStripMenuItem;
        private ToolStripMenuItem repeatToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem alphaMenuItem;
        private ToolStripMenuItem bgColorMenuItem;
        private ToolStripMenuItem brightnessMenuItem;
        private ToolStripMenuItem detectEdgesMenuItem;
        private ToolStripMenuItem entropyCropMenuItem;
        private ToolStripMenuItem filterMenuItem;
        private ToolStripMenuItem gaussBlurMenuItem;
        private ToolStripMenuItem gaussSharpenMenuItem;
        private ToolStripMenuItem hueMenuItem;
        private ToolStripMenuItem pixelateMenuItem;
        private ToolStripMenuItem qualityMenuItem;
        private ToolStripMenuItem replaceColorMenuItem;
        private ToolStripMenuItem cornersMenuItem;
        private ToolStripMenuItem saturationMenuItem;
        private ToolStripMenuItem tintMenuItem;
        private ToolStripMenuItem vignetteMenuItem;
    }
}

