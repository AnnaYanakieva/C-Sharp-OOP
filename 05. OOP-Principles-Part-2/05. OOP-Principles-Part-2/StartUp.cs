namespace _05.OOP_Principles_Part_2
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {

            var differentShapes = new List<Shape>()
            {
                 new Square(5),
                 new Triangle(5, 10),
                 new Rectangle(4, 2.5),
                 new Triangle(10,20),
                 new Square(4)
        };

            foreach (Shape shape in differentShapes)
            {
                Console.WriteLine("{0} surface: {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
