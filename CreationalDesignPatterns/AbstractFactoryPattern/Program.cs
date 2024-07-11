using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a pet animal factory
            IAnimalFactory petFactory = new PetAnimalFactory();

            IDog petDog = petFactory.GetDog();
            Console.WriteLine("Pet Animal Factory:");
            Console.WriteLine("-------------------");
            petDog.Speak();
            petDog.Action();

            ITiger petTiger = petFactory.GetTiger();
            petTiger.Speak();
            petTiger.Action();

            Console.WriteLine();

            //Create a wild Factory
            IAnimalFactory wildFactory = new WildAnimalFactory();

            IDog wildDog = wildFactory.GetDog();
            Console.WriteLine("Pet Animal Factory:");
            Console.WriteLine("-------------------");
            petDog.Speak();
            petDog.Action();

            ITiger wildTiger = wildFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();

            Console.WriteLine();

        }
    }
}