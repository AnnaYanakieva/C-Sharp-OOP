namespace DefiningClassesPart2
{
    using System;

    public struct Point3D
    {
        //fields
        private static readonly Point3D startOfCoordinateSystem = new Point3D() { X = 0, Y = 0, Z = 0 };
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //properties
        public double X 
        {
            get{return this.x;}
            set{ this.x = value;}
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D StartOfCoordinateSystem
        {
            get { return startOfCoordinateSystem; }
        }

        //methods
        public override string ToString()
        {
            string point = string.Format("X : {0}, Y : {1}, Z : {2}", this.X, this.Y, this.Z);
            return point;
        }     
    }
}

