namespace DefiningClassesPart2
{
    using System;

    public static class CalculateDistance
    {
        static double xDistance;
        static double yDistance;
        static double zDistance;
        public static double CalculateDistanceBetween2Points(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;
            xDistance = secondPoint.X - firstPoint.X;
            yDistance = secondPoint.Y - firstPoint.Y;
            zDistance = secondPoint.Z - firstPoint.Z;
            distance = Math.Sqrt(xDistance * xDistance + yDistance * yDistance + zDistance * zDistance);
            return distance;
        }
    }
}
