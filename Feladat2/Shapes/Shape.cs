using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape : Shape_Interface
    {
        protected double x, y;

        public Shape(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();

        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }

        public void Info()
        {
            Console.WriteLine("Type: {0}\tCoordinates: {1} {2}\tArea: {3}", Name(), getX(), getY(), Area());
        }

        public abstract string Name();
    }
}
