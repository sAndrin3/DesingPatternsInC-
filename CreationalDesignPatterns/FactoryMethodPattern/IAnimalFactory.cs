using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class IAnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("IAnimalFactory.MakeAnimal()-You cannot ignore parent rules.\n\n");

            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }

        public abstract IAnimal CreateAnimal();
    }
}