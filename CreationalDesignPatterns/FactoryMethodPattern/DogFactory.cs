using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class DogFactory  : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            //Creating a dog
            return new Dog();
        }
    }
}