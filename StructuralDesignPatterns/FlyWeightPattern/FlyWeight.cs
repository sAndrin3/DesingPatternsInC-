// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace FlyWeightPattern
// {
//    class Program
//    {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("***********");
//         List<Context> contexts = new List<Context>();
//         for (int i = 0; i < 10000000; i++)
//         {
//             Context context = new Context("Argument");
//             contexts.Add(context);
//         }
//         Console.ReadLine();
//     }
//    }

//    class Context
//    {
//     string ID;

//     string Property_1;
//     string Property_2;
//     string Property_3;
//     string Property_4;

//     public string Context(string Property_1)
//     {
//         this.Property_1 = Property_1;
//         this.Property_2 = Property_1 + "Something else";
//         this.Property_3 = Property_2 + "Something else";
//         this.Property_4 = Property_1 + Property_2;
//     }
//    }
// }