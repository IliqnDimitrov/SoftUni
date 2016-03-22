using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Rhombus : BasicShape
    {
        public Rhombus(double a, double ha)
            :base(a,ha)
        {

        }

        public override double CalculatePerimeter()
        {
            double P = 4 * this.Weidth;
            return P;
        }

        public override double CalculateArea()
        {
            double A = this.Weidth * this.Height;
            return A;
        }
    }
}
