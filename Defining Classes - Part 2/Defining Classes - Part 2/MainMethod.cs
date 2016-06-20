namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;

    class Class1
    {
        static void Main()
        {
            Path test = new Path();
           
            Point3D point1 = new Point3D(1, 2.5, 3);
            Point3D point2 = new Point3D(4, 5, 6);
            Point3D point3 = new Point3D(7, 8, 9);

            test.AddPoint(point1);      
            test.AddPoint(point2);
            test.AddPoint(point3);

            Point3D point = new Point3D() { X = 1, Y = 1, Z = 1 };
            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartOfCoordinateSystem);

            var result = CalculateDistance.CalculateDistanceBetween2Points(point, Point3D.StartOfCoordinateSystem);
            Console.WriteLine();
            Console.WriteLine("Distance between point and start of coordinate system:\n{0}",result);
            Console.WriteLine();
            PathStorage.SavePath(test);
            Console.WriteLine("Loaded paths:");
            Console.WriteLine(PathStorage.ReadPath());           
        }
    }
}
