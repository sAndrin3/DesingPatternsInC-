using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Rect : IRect
    {
        public double Length;
        public double Width;
        public Rect(double l, double w)
        {
            this.Length = l;
            this.Width = w;
        }
        public double CalculatedAreaOfRectangle()
        {
            return Length * Width;
        }
        public void AboutRectangle()
        {
            Console.WriteLine("\nActually, I am a Rectangle\n");
        }
    }
}