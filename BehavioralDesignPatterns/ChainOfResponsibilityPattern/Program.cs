using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******COR********");

            Handle_1 handle_1 = new Handle_1();
            Handle_2 handle_2 = new Handle_2();

            handle_1.SetHandler(handle_2);

            handle_1.HandleRequest("This is my argument");
            handle_1.HandleRequest(100);
            handle_1.HandleRequest(100.0f);

            Console.ReadLine();
        }
    }

    abstract class Handler
    {
        public abstract void SetHandler(Handler handler);
        public virtual void HandleRequest(object o)
        {
            Console.WriteLine($"The Request cannot be handled.");
        }
    }

    class Handle_1 : Handler
    {
        private Handler _handler;
        public override void SetHandler(Handler handler)
        {
            _handler = handler;
        }

        public override void HandleRequest(object o)
        {
            if(o.GetType() == typeof(string))
            {
                Console.WriteLine($"The Argument is from type string.");
            }
            else
            {
                if(_handler != null)
                {
                    _handler.HandleRequest(o);
                }
                else
                {
                    base.HandleRequest(o);
                }
            }
        }
    }

     class Handle_2 : Handler
    {
        private Handler _handler;
        public override void SetHandler(Handler handler)
        {
            _handler = handler;
        }

        public override void HandleRequest(Object o)
        {
            if(o.GetType() == typeof(int))
            {
                Console.WriteLine($"The Argument is from type interger.");
            }
            else
            {
                if(_handler != null)
                {
                    _handler.HandleRequest(o);
                }
                else
                {
                    base.HandleRequest(o);
                }
            }
        }
    }
}