using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Employee : IEmployee
    {
        public Employee(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
        }

        public string Name {get; set; }
        public string Department {get; set; }

        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format("Name:{0}, Dept: {1} (Leaf)",
            new string('-', indentation),
            this.Name.ToString(), this.Department));
        }
    }
}