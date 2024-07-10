using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.SimpleFactoryDesignPatterns
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal(int input)
        {
            IAnimal intendedAnimal = null;
            switch (input)
            {
                case 0:
                    intendedAnimal = new Dog();
                    break;
                case 1:
                    intendedAnimal = new Tiger();
                    break;
                default:
                    throw new ApplicationException(string.Format("Unknown Animal cannot be instantiated"));
            }
            return intendedAnimal;
        }        
    }
}