namespace _05.OOP_Principles_Part_2
{

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width)
        {
            this.width = width;
        }
        public Shape(double width, double height):this(width)
        {            
            this.height = height;
        }
        
        public double Width { get { return this.width; } set { this.width = value; } }
        public double Height { get { return this.height; } set { this.height = value; } }

        public abstract double CalculateSurface();
    }
}
