using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TriangleAdapter : IRect
    {
        Triangle triangle;
        public TriangleAdapter(Triangle t)
        {
            this.triangle = t;
        }
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }
        public double CalculatedAreaOfRectangle()
        {
            return triangle.CalculatedAreaOfTriangle();
        }
    }
}