namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> sequenceOfPoints;

        //constructors
        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();
        }

        //properties
        public List<Point3D> SequenceOfPoints
        {
            get { return this.sequenceOfPoints; }
            set { this.sequenceOfPoints = value; }
        }

        //methods
        public void AddPoint(Point3D point)
        {
            this.sequenceOfPoints.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.sequenceOfPoints.Remove(point);
        }
    }
}
