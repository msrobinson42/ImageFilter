using ImageProcessor;
using ImageProcessor.Imaging.Filters.EdgeDetection;
using ImageProcessor.Imaging.Filters.Photo;
using ImageProcessor.Imaging.Formats;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilterLibrary
{
    public sealed class ImageProcessor
    {
        private ImageProcessor()
        {

        }

        public static ImageProcessor Instance { get; } = new ImageProcessor();

        public Image Alpha(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Alpha(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image BackgroundColor(Image image, Color color)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.BackgroundColor(color);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Brightness(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Brightness(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Constrain(Image image, Size size)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Constrain(size);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Contrast(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Contrast(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image DetectEdges(Image image, IEdgeFilter filter, bool greyscale = true)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.DetectEdges(filter, greyscale);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image EntropyCrop(Image image, byte threshold = 128)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.EntropyCrop(threshold);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Filter(Image image, IMatrixFilter matrixFilter)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Filter(matrixFilter);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Format(Image image, ISupportedImageFormat format)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Format(format);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image GaussianBlur(Image image, int size)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.GaussianBlur(size);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image GaussianSharpen(Image image, int size)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.GaussianSharpen(size);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Hue(Image image, int degrees, bool rotate = false)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Hue(degrees, rotate);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Pixelate(Image image, int radius)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Pixelate(radius);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Quality(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Quality(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image ReplaceColor(Image image, Color target, 
            Color replacement, int fuzziness = 0)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.ReplaceColor(target, replacement, fuzziness);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Rotate(Image image, int degrees)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Rotate(degrees);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image RoundedCorners(Image image, int degrees)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.RoundedCorners(degrees);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Saturation(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Saturation(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Tint(Image image, Color color)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Tint(color);

            var result = factory.Image;

            return new Bitmap(result);
        }

        public Image Vignette(Image image, Color color)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Vignette(color);

            var result = factory.Image;

            return new Bitmap(result);
        }

    }
}
