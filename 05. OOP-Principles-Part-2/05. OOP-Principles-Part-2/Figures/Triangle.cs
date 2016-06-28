﻿namespace _05.OOP_Principles_Part_2
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height):base(width,height)
        {

        }
        public override double CalculateSurface()
        {
            double surface = this.Height * (this.Width / 2);
            return surface;
        }
    }
}
