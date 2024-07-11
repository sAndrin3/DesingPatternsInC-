using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IRect rectangle = new Rect(5, 10);
            Triangle triangle = new Triangle(4, 6);

            //Create an adapter for the triangle
            IRect triangleAdapter = new TriangleAdapter(triangle);

            rectangle.AboutRectangle();
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculatedAreaOfRectangle()}");

            triangleAdapter.AboutRectangle();
            Console.WriteLine($"Area of Triangle (via Rectangle adapter): {triangleAdapter.CalculatedAreaOfRectangle()}");

            Console.ReadKey();
        }
    }
}