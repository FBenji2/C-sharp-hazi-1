using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Editbox : Controls.Textbox, Shape_Interface
    {
        int height, width;

        public Editbox(int x,int y,int height, int width): base(x,y,height,width)
        {
            this.height = height;
            this.width = width;
        }

        public double Area()
        {
            return width * height;
        }

        public void Info()
        {
            Console.WriteLine("Type: {0}\tCoordinates: {1} {2}\tArea: {3}", Name(), GetX(), GetY(), Area());
        }

        public string Name()
        {
            return "Editbox";
        }
    }
}
