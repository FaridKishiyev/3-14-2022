using System;
using class_vehiclecar.Models;
namespace class_vehiclecar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cars = new Car("Mercedes", "AMG", "Black", 2008, 80, 0.3, 30);
            cars.ShowInfo();
            Console.WriteLine("way to go");
            string input = Console.ReadLine();
            double distance = Convert.ToDouble(input);
            Console.WriteLine($"Current Fuel:{cars.Drive(distance)} liter");
        }
    }
}
