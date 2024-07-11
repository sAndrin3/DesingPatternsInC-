using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Product
    {
        private List<string> parts;
        public Product()
        {
            parts = new List<string>();
        }
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\n\nProduct completed as below:\n");
            Console.WriteLine("*********************************");
            foreach(string part in parts)
                Console.WriteLine(part+"\n");
        }
    }
}