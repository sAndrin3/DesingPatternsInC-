using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;
        private int numberOfInstances = 0;

        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.\n\n");
            numberOfInstances++;
            Console.WriteLine(string.Format("Number of instances ={0}\n\n", numberOfInstances));
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
    public sealed class SingletonTS
    {
        private static volatile SingletonTS instance;
        private static object lockObject = new Object();
        private SingletonTS() {Console.WriteLine("Instatiating thread-safe inside the private constructor.\n\n");}
        public static SingletonTS Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(lockObject)
                    {
                        if(instance == null)
                            instance = new SingletonTS();
                    }
                }
                return instance;
            }
        }
    }
}