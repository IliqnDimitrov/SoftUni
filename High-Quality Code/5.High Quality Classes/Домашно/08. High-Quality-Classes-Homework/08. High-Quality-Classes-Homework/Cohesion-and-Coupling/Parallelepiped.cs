namespace CohesionAndCoupling
{
    using System;
    using CohesionAndCoupling.Utils;

    class Parallelepiped
    {
        private double width;
        private double height;
        private double depth;

        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Parallelepiped width can not be negative or zero");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Parallelepiped height can not be negative or zero");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get { return this.depth; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Parallelepiped depth can not be negative or zero");
                }

                this.depth = value;
            }
        }

        /// <summary>
        /// Calculates Parallelepiped volume
        /// </summary>
        /// <returns>
        /// Floating point value
        /// </returns>
        public double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        /// <summary>
        /// Calculates diagonal X,Y,Z
        /// </summary>
        /// <returns>
        /// floating point value
        /// </returns>
        public double CalcDiagonalXYZ()
        {
            double distance = CalculateDistanceUtils.CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        /// <summary>
        /// Calculates diagonal X,Y
        /// </summary>
        /// <returns>
        /// floating point value
        /// </returns>
        public double CalcDiagonalXY()
        {
            double distance = CalculateDistanceUtils.CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        /// <summary>
        /// Calculates diagonal X,Z
        /// </summary>
        /// <returns>
        /// floating point value
        /// </returns>
        public double CalcDiagonalXZ()
        {
            double distance = CalculateDistanceUtils.CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        /// <summary>
        /// Calculates diagonal Y,Z
        /// </summary>
        /// <returns>
        /// floating point value
        /// </returns>
        public double CalcDiagonalYZ()
        {
            double distance = CalculateDistanceUtils.CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
