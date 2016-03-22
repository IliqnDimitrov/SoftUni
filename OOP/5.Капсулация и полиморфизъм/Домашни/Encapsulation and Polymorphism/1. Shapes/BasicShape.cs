using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public double Weidth { get; set; }
        public double Height { get; set; }


        protected BasicShape(double width)
        {
            this.Weidth = width;
            
        }
        protected BasicShape(double width, double height)
            :this(width)
        {
            this.Height = height;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
