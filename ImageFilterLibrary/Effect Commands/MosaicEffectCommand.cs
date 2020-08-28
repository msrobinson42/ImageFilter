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

        public Bitmap Execute()
        {
            var newImage = new Bitmap(_image);
            int x, y;
            int sectionLength = _radius;
            Color[,] section = new Color[sectionLength, sectionLength];
            int r = 0, g = 0, b = 0;
            byte rAvg, gAvg, bAvg;
            int pixelCount;
            

            for (x = 0; x < sectionLength; x++)
            {
                for (y = 0; y < sectionLength; y++)
                {
                    section[x, y] = newImage.GetPixel(x, y);
                }
            }

            pixelCount = section.Length;

            foreach (Color color in section)
            {
                r += color.R;
                g += color.G;
                b += color.B;
            }

            rAvg = (byte)(r / pixelCount);
            gAvg = (byte)(g / pixelCount);
            bAvg = (byte)(b / pixelCount);

            for (x = 0; x < sectionLength; x++)
            {
                for (y = 0; y < sectionLength; y++)
                {
                    newImage.SetPixel(x, y, Color.FromArgb(rAvg, gAvg, bAvg));
                }
            }

            return newImage;
        }

        public Bitmap Unexecute()
        {
            return _image;
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
