namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw1 = new Bmw("BMW X3");
            Ford ford1 = new Ford("Ford Mustang");

            Bmw bmw2 = (Bmw)bmw1.Clone();
            Ford ford2 = (Ford)ford1.Clone();

            Console.WriteLine("Original BMW Car:");
            Console.WriteLine($"Model: {bmw1.ModelName}, Price: {bmw1.Price}");

            Console.WriteLine("\nCloned BMW Car:");
            Console.WriteLine($"Model: {bmw2.ModelName}, Price: {bmw2.Price}");

            Console.WriteLine("\nOriginal Ford Car:");
            Console.WriteLine($"Model: {ford1.ModelName}, Price: {ford1.Price}");

            Console.WriteLine("\nCloned Ford Car:");
            Console.WriteLine($"Model: {ford2.ModelName}, Price: {ford2.Price}");

            Console.ReadKey();
        }
    }
}