using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; } 
        public double Width { get; set; }  

        public Rectangle(string name, double width, double length) : base(name)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public void VirtualDisplay()
        {
            base.VirtualDisplay();
            Console.WriteLine($"Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
        }

    }
}
