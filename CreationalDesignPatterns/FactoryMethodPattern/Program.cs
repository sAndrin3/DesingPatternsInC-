using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory dogFactory = new DogFactory();
            IAnimalFactory tigerFactory = new TigerFactory();

            Console.WriteLine("Creating and using DogFactory:");
            IAnimal dog = dogFactory.MakeAnimal();
            Console.WriteLine();

            Console.WriteLine("Creating and using TigerFactory:");
            IAnimal tiger = tigerFactory.MakeAnimal();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}