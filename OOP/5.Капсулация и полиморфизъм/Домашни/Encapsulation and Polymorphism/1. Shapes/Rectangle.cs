using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            :base(width,height)
        {
            
        }

        public override double CalculatePerimeter()
        {
            double P = (this.Weidth + this.Height) * 2;
            return P;
        }
        public override double CalculateArea()
        {
            double A = this.Weidth * this.Height;
            return A;
        }
    }
}
