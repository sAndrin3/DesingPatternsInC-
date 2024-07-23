using System;

namespace ProxyPattern
{
    class Program
    {
        // ProxyPattern

        static void Main(string[] args)
        {
            Console.WriteLine("*****PROXY******");

            IService concreteService = new ConcreteService();
            IService proxy = new Proxy(concreteService);

            concreteService.Login(15);
            proxy.Login(15);

            concreteService.Login(18);
            proxy.Login(18);

            Console.ReadLine();
        }

        interface IService
        {
            void Login(int age);
        }

        class ConcreteService : IService
        {
            public void Login(int age)
            {
                Console.WriteLine($"You are logged in. Your age is {age}");
            }
        }

        class Proxy : IService
        {
            private IService _service;
            public Proxy(IService service)
            {
                _service = service;
            }
            public void Login(int age)
            {
                if (age < 18)
                {
                    Console.WriteLine($"You are too young.");
                }
                else
                {
                    _service.Login(age);
                }
            }
        }
    }
}