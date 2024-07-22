using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
   class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("***********");
            List<Context> contexts = new List<Context>(); // 4GB memory
            for (int i = 0; i < 10000000; i++)
            {
                Context context = new Context("Argument");
                contexts.Add(context);
            }
            Console.WriteLine(contexts.Count);
            Console.ReadLine();
        }
    }

    static class FlyWeightFactory
    {
        private static Dictionary<string, FlyWeight> _flyweights = new Dictionary<string, FlyWeight>();
        public static FlyWeight GetFlyWeight (string Property_1)
        {
            if (_flyweights.ContainsKey(Property_1))
            {
                return _flyweights[Property_1];
            }
            else
            {
                _flyweights.Add(Property_1, new SharedFlyWeight(Property_1));
                return _flyweights[Property_1];
            }
        }
    }

    interface FlyWeight
    {

    }

    class SharedFlyWeight : FlyWeight
    {
    //Intrinsic State = shared
    string Property_1;
    string Property_2;
    string Property_3;
    string Property_4;
    }

    public SharedFlyWeight(string Property_1)
    {
        this.Property_1 = Property_1;
        this.Property_2 = Property_1 + "Something else";
        this.Property_3 = Property_2 + "Something else";
        this.Property_4 = Property_1 + Property_2;
    }
   class Context
   {
    //Extrinsic state = unshared
    string ID;
    FlyWeight flyWeight;
    public  Context(string Property_1)
    {
        this.flyWeight = FlyWeightFactory.GetFlyWeight(Property_1);
        this.ID = DateTime.Now.GetHashCode().ToString("x");
    }
   }
}