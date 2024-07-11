using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non-Thread-Safe Singleton:");
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            Console.WriteLine($"Instance 1 == Instance 2 : {instance1 == instance2}");
            Console.WriteLine();

            Console.WriteLine("Thread-Safe Singleton:");
            Singleton instance3 = Singleton.Instance;
            Singleton instance4 = Singleton.Instance;

            Console.WriteLine($"Instance 3 == Instance 4 : {instance3 == instance4}");

            Console.ReadKey();
        }
    }
}