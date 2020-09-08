using ImageProcessor.Imaging.Filters.EdgeDetection;
using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilterLibrary
{
    public static class Resources
    {
        public static List<IEdgeFilter> EdgeFilters { get; } = new List<IEdgeFilter>
        {
            new KayyaliEdgeFilter(),
            new KirschEdgeFilter(),
            new Laplacian3X3EdgeFilter(),
            new Laplacian5X5EdgeFilter(),
            new LaplacianOfGaussianEdgeFilter(),
            new PrewittEdgeFilter(),
            new RobertsCrossEdgeFilter(),
            new ScharrEdgeFilter(),
            new SobelEdgeFilter()
        };

        public static List<IMatrixFilter> PhotoFilters { get; } = new List<IMatrixFilter>
        {
            MatrixFilters.BlackWhite,
            MatrixFilters.Comic,
            MatrixFilters.Gotham,
            MatrixFilters.GreyScale,
            MatrixFilters.HiSatch,
            MatrixFilters.Invert,
            MatrixFilters.Lomograph,
            MatrixFilters.LoSatch,
            MatrixFilters.Polaroid,
            MatrixFilters.Sepia
        };
    }
}
