using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{

    class Circle: Shape
    {
        private double radius;

        public Circle(double x, double y,double r):base(x,y)
        {
            radius = r;
        }
        
        public override double Area()
        {
            return radius * radius * 3.141592653589793;
        }

        public override string Name()
        {
            return "Circle";
        }
    }
}
