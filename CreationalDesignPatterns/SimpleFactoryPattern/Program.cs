using System;

namespace CreationalDesignPatterns.SimpleFactoryDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ISimpleFactory factory = new SimpleFactory();

            IAnimal dog = factory.CreateAnimal(0);
            IAnimal tiger = factory.CreateAnimal(1);

            Console.WriteLine("Dog actions:");
            dog.Speak();
            dog.Action();

            Console.WriteLine("tiger actions:");
            tiger.Speak();
            tiger.Action();

            Console.ReadLine();
        }
    }
}