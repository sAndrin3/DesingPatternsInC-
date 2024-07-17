using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee John = new Employee("John", "IT");
            IEmployee Doe = new Employee("Doe", "IT");
            IEmployee Jean = new Employee("Jean", "HR");
            IEmployee Ann = new Employee("Ann", "HR");

            IEmployee James = new Manager("James", "IT")
            { SubOrdinates = {John, Doe}};
            IEmployee Philip = new Manager("Philip", "HR")
            { SubOrdinates = {Jean, Ann}};

            IEmployee Bob = new Manager("Bob", "Head")
            { SubOrdinates = {James, Philip}};

            Bob.GetDetails(1);

            Console.ReadLine();
        }
    }
}