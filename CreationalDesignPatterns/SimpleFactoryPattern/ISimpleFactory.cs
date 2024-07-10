using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.SimpleFactoryDesignPatterns
{
  
        public abstract class ISimpleFactory
        {
            public abstract IAnimal CreateAnimal(int selectedAnimal);
        }

}