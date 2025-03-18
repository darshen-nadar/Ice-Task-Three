using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
     public abstract class Shape : iCalculateArea
    {

        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual void VirtualDisplay()
        {
            Console.WriteLine($"Shape: {Name}");
        }

        public abstract double CalculateArea();
    }
}