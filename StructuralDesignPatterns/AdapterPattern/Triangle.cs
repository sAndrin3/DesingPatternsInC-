using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Triangle : ITriangle
    {
        public double BaseLength;
        public double Height;
        public Triangle(double b, double h)
        {
            this.BaseLength = b;
            this.Height = h;
        }
        public double CalculatedAreaOfTriangle()
        {
            return 0.5 * BaseLength * Height;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("\nActually, I am a Triangle\n");
        }
    }
}