using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
   internal class Circle : Shape 
    {
        public double Radius { get; set; } 

        public Circle (string name, int radius): base (name)
        {
            Radius = radius;
        }

        //Calculate Area

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
        public void VirtualDisplay()
        {
            base.VirtualDisplay();
            Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea()}");
        }

    }
}
