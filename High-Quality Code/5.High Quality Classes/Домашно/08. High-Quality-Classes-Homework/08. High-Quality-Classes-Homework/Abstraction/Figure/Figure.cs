namespace Abstraction.Figure
{
    using System;

    internal abstract class Figure : IFigure
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();

        public override string ToString()
        {
            string output = string.Format("Perimeter: {0:F2}, Surface: {1:F2}", 
                this.CalculatePerimeter(), this.CalculateSurface());
            return output;
        }
    }
}
