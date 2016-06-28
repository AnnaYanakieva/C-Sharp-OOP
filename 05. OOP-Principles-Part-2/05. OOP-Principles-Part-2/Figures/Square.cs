namespace _05.OOP_Principles_Part_2
{
    public class Square : Shape
    {
        public Square(double width) : base(width)
        {
        }

        public override double CalculateSurface()
        {
            double surface = Width * Width;
            return surface;
        }
    }
}
