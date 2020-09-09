using ImageProcessor.Imaging.Filters.EdgeDetection;
using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Collections.Generic;
using System.Text;

//Holds static resources for UI implementation of
// the Filter and DetectEdge methods.

namespace ImageFilterLibrary
{
    public static class Resources
    {
        /// <summary>
        /// Holds object instantations of all possible IEdgeFilter concretions.
        /// </summary>
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

        /// <summary>
        /// Holds object instantiations of all possible IMatrixFilter concretions.
        /// </summary>
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

        /// <summary>
        /// Holds information for all possible Flip values.
        /// </summary>
        public static List<string> FlipValues { get; } = new List<string>
        {
            "Horizontal",
            "Vertical"
        };
    }
}
