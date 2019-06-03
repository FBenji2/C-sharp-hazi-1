using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square: Shape
    {
        private double sidelength;

        public Square(double x, double y, double s): base(x,y)
        {
            sidelength = s;
        }

        public override double Area()
        {
            return sidelength * sidelength;
        }

        public override string Name()
        {
            return "Square";
        }
    }
}
