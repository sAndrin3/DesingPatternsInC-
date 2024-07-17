using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicGoods dvdPlayer = new DVD();
            ElectronicGoods tv = new Television();

            dvdPlayer.State = new OnState();
            tv.State = new OffState();

            Console.WriteLine("DVD Player:");
            dvdPlayer.MoveToCurrentState();

            Console.WriteLine("TV:");
            tv.MoveToCurrentState();

            dvdPlayer.State = new OffState();
            tv.State = new OnState();

            Console.WriteLine("TV (after state change):");
            tv.MoveToCurrentState();

            Console.ReadLine();
        }
    }
}