namespace Abstraction
{
    /// <summary>
    /// Interface class capable of creating figure.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculate Figure Perimeter
        /// </summary>
        /// <returns>
        /// floating-point value
        /// </returns>
        double CalculatePerimeter();

        /// <summary>
        /// Calculate Figure Surface
        /// </summary>
        /// <returns>
        /// floating-point value
        /// </returns>
        double CalculateSurface();
    }
}