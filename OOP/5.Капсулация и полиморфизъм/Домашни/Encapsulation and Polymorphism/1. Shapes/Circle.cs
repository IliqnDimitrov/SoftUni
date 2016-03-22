using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Circle : BasicShape
    {
        public Circle(double r)
            :base(r)
        {

        }

        public override double CalculatePerimeter()
        {
            double P = 2 * Math.PI * this.Weidth;
            return P;
        }

        public override double CalculateArea()
        {
            double S = Math.PI * this.Weidth * this.Weidth;
            return S;
        }
    }
}
