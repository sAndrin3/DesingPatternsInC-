using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IBuilder carBuilder = new Car("Toyota");
            director.Construct(carBuilder);
            Product car = carBuilder.GetVehicle();
            car.Show();

            IBuilder motorCycleBuilder = new MotorCycle("Kawasaki");
            director.Construct(motorCycleBuilder);
            Product MotorCycle = motorCycleBuilder.GetVehicle();
            MotorCycle.Show();

            Console.ReadLine();
        }
    }
}