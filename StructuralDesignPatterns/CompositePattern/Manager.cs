using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Manager : IEmployee
    {
        public List<IEmployee> SubOrdinates;
        public Manager(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
            SubOrdinates = new List<IEmployee>();
        }

        public string Name {get; set; }
        public string Department {get; set; }

        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format("Name:{0}, Dept:{1}" + 
                "Dept:{2} - Manager(Composite)",
                new string('-', indentation),
            this.Name.ToString(), this.Department));

            foreach(var employee in SubOrdinates)
            {
                employee.GetDetails(indentation + 1);
            }
        }
    }
}