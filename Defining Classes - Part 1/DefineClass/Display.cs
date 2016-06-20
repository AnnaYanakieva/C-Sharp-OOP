using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Display
    {
        private double size;
        private int numberOfColors;

        //constructors
        public Display(double size)
        {
            this.size = size;
        }

        //properties
        public double Size
        {
            get
            { return this.size; }
            set
            {
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
