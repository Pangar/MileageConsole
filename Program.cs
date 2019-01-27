using System;

namespace MileageConsole
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Welcome To The Mileage Tracker");
            Trip trip = new Trip();

            Console.Write("Enter Starting Lcoation: ");
            trip.DateTime = DateTime.Now;
            trip.startLocation = Console.ReadLine();

            Console.Write("Enter Finish Location: ");
            trip.endLocation = Console.ReadLine();

            Console.WriteLine($"Your Trip consists of:\n{trip.DateTime}\n{trip.startLocation}\n{trip.endLocation}");

        }
    }
}
