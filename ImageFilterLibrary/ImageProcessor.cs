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
    /// <summary>
    /// Singleton class allowing access to a single copy of an ImageProcessor.
    /// </summary>
    public sealed class ImageProcessor
    {
        private ImageProcessor()
        {

        }

        /// <summary>
        /// Retrieves the singleton instance of the ImageProcessor.
        /// </summary>
        public static ImageProcessor Instance { get; } = new ImageProcessor();

        /// <summary>
        /// Performs the Alpha method from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="percentage">The amount of transparency as a percentage.</param>
        /// <returns>A new image with the Alpha effect applied.</returns>
        public Image Alpha(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Alpha(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the BackgroundColor effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="color">The color to display as the background color.</param>
        /// <returns>A new image with the BackgroundColor effect applied.</returns>
        public Image BackgroundColor(Image image, Color color)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.BackgroundColor(color);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the Brightness effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="percentage">The amount of brightness as a percentage.</param>
        /// <returns>A new image with the Brightness effect applied.</returns>
        public Image Brightness(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Brightness(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the Constrain effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="size">The size with which the Constrain effect will be applied.</param>
        /// <returns>A new image with the Constrain effect applied.</returns>
        public Image Constrain(Image image, Size size)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Constrain(size);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the Contrast effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="percentage">The amount of contrast as a percentage.</param>
        /// <returns>A new image with the Contrast effect applied.</returns>
        public Image Contrast(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Contrast(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the DetectEdges effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="filter">The IEdgeFilter object that will detect the edges.</param>
        /// <param name="greyscale">Whether or not the resulting image will be greyscale.</param>
        /// <returns>A new image with the DetectEdges effect applied.</returns>
        public Image DetectEdges(Image image, IEdgeFilter filter, bool greyscale = true)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.DetectEdges(filter, greyscale);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the EntropyCrop effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="threshold">The value used to determine where the crop will occur.</param>
        /// <returns>A new image with the EntropyCrop effect applied.</returns>
        public Image EntropyCrop(Image image, byte threshold = 128)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.EntropyCrop(threshold);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the Filter effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="matrixFilter">The IMatrixFilter used to apply the effect.</param>
        /// <returns>A new image with the Filter effect applied.</returns>
        public Image Filter(Image image, IMatrixFilter matrixFilter)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Filter(matrixFilter);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the Flip effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="verticalFlip">Determines if the flip should be vertical or horizontal.</param>
        /// <returns>A new image with the effect applied.</returns>
        public Image Flip(Image image, bool verticalFlip)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Flip(verticalFlip);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs the Format effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="format">The ISupportedImageFormat that the Image will be converted to upon saving.</param>
        /// <returns>A new image that will be saved with the corresponding ImageFormat.</returns>
        public Image Format(Image image, ISupportedImageFormat format)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Format(format);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Blur effect using a Gaussian distribution from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="size">The size of the kernel used to perform the blur.</param>
        /// <returns>A new image with the Blur effect applied.</returns>
        public Image GaussianBlur(Image image, int size)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.GaussianBlur(size);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Sharpen effect using a Gaussian distribution from the ImageProcessor library..
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="size">The size of the kernel used to perform the blur.</param>
        /// <returns>A new image with the Sharpen effect applied.</returns>
        public Image GaussianSharpen(Image image, int size)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.GaussianSharpen(size);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Hue effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="degrees">Used to find a color at a particular point around the color wheel.</param>
        /// <param name="rotate">Used to determine whether all pixels color value rotate as one, or individually.</param>
        /// <returns>A new image with the Hue effect applied.</returns>
        public Image Hue(Image image, int degrees, bool rotate = false)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Hue(degrees, rotate);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Pixelate effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="radius">Determines how large each resulting pixel will be.</param>
        /// <returns>A new image with the Pixelate effect applied.</returns>
        public Image Pixelate(Image image, int radius)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Pixelate(radius);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Quality effect from the ImageProcessor Library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="percentage">Determines the relative quality of the image when it is saved.</param>
        /// <returns>A new image with data that determines it's quality when saved through ImageProcessor.</returns>
        public Image Quality(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Quality(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a ReplaceColor effect from the ImageProcessor Library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="target">The target color that is being replaced.</param>
        /// <param name="replacement">The replacement color that will be the resultant color.</param>
        /// <param name="fuzziness">The preciseness of chosen target color.
        /// Higher value leads to more general color replacement.</param>
        /// <returns>A new image with the ReplaceColor effect applied.</returns>
        public Image ReplaceColor(Image image, Color target, 
            Color replacement, int fuzziness = 0)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.ReplaceColor(target, replacement, fuzziness);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Rotate effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="degrees">The amount of rotation in degrees.</param>
        /// <returns>A new image with the rotation applied. 
        /// A background-color of black will be used to fill in any empty space
        /// when image is rotated off the quarter-turn.</returns>
        public Image Rotate(Image image, int degrees)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Rotate(degrees);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a RoundedCorners effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="radius">The radius of the rounded corner.</param>
        /// <returns>A new image with Rounded Corners.
        /// A background-color of black will be used to fill in any empty space
        /// left over after the effect.</returns>
        public Image RoundedCorners(Image image, int radius)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.RoundedCorners(radius);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Saturation effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="percentage">The amount of saturation in percentage.</param>
        /// <returns>A new image with the Saturation effect applied.</returns>
        public Image Saturation(Image image, int percentage)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Saturation(percentage);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Tint effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="color">The color used to apply the effect.</param>
        /// <returns>A new image with the Tint effect applied.</returns>
        public Image Tint(Image image, Color color)
        {
            using var factory = new ImageFactory();

            factory.Load(image);
            factory.Tint(color);

            var result = factory.Image;

            return new Bitmap(result);
        }

        /// <summary>
        /// Performs a Vignette effect from the ImageProcessor library.
        /// </summary>
        /// <param name="image">The image with which to apply the effect.</param>
        /// <param name="color">The color used to apply the effect.</param>
        /// <returns>A new image with the Vignette effect applied.</returns>
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
