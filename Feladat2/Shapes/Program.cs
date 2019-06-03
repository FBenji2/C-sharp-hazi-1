using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape_Interface> shapes = new List<Shape_Interface>();

            Square s = new Square(1, 2, 3);
            Circle c = new Circle(4, 5, 6);
            Editbox e = new Editbox(7, 8, 9, 10);

            shapes.Add(s);
            shapes.Add(c);
            shapes.Add(e);

            foreach (var item in shapes)
            {
                item.Info();
            }


            Console.ReadKey();

        }
    }
}
