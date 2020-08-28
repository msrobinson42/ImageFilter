using ImageFilterLibrary.EffectCommands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary.Effect_Commands
{
    public class MosaicEffectCommand : IBitmapEffectCommand
    {
        private readonly Bitmap _image;
        private readonly int _radius;

        public MosaicEffectCommand(Bitmap image, int radius)
        {
            _image = image;
            _radius = radius;
        }

        public MosaicEffectCommand(Bitmap image)
            : this(image, 100)
        {

        }

        public Bitmap Execute()
        {
            return LoopThroughSections();
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        private Bitmap ColorMosaicSection(Bitmap image, int r, int g, int b, int xPointer, int yPointer)
        {
            int initX = 0 + (_radius * xPointer);
            int initY = 0 + (_radius * yPointer);
            int xLimit = _radius * (xPointer + 1);
            int yLimit = _radius * (yPointer + 1);

            for (int x = initX; x < xLimit && x < image.Width; x++)
            {
                for (int y = initY; y < yLimit && x < image.Height; y++)
                {
                    image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return image;
        }

        private int[] FindSectionAverageRGB(Bitmap image, int xPointer, int yPointer)
        {
            int initX = 0 + (_radius * xPointer);
            int initY = 0 + (_radius * yPointer);
            int xLimit = _radius * (xPointer + 1);
            int yLimit = _radius * (yPointer + 1);
            int r = 0, g = 0, b = 0;
            int counter = 0;

            for (int x = initX; x < xLimit && x < image.Width; x++)
            {
                for (int y = initY; y < yLimit && x < image.Height; y++)
                {
                    r += image.GetPixel(x, y).R;
                    g += image.GetPixel(x, y).G;
                    b += image.GetPixel(x, y).B;
                    counter++;
                }
                counter++;
            }

            return new int[] { r / counter, g / counter, b / counter };
        }

        private Bitmap LoopThroughSections()
        {
            var image = new Bitmap(_image);
            int xPointer = 0, yPointer = 0;
            var sectionsCount = (image.Width / _radius) * (image.Height / _radius);

            for (int i = 0; i < sectionsCount; i++)
            {
                var rgbAvg = FindSectionAverageRGB(image, xPointer, yPointer);
                image = ColorMosaicSection(image, rgbAvg[0], rgbAvg[1], rgbAvg[2], xPointer, yPointer);

                xPointer = ++xPointer % (_image.Width / _radius);

                if (xPointer == 0)
                {
                    yPointer++;
                }
            }
                return image;
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
