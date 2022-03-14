using System;
namespace class_vehiclecar.Models
{
    public class Car : Vehicle
    {
        public string brand;
        public string model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string brand, string model, string color, int year, double FuelCapacity, double FuelFor1Km, double CurrentFuel) : base(color, year)
        {
            this.brand = brand;
            this.model = model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
            this.CurrentFuel = CurrentFuel;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{brand}\nModel:{model}\nColor:{Color}\nYear:{Year}\nFuelCapacity:{FuelCapacity}l\nFuerFor1Km:{FuelFor1Km}l\nCurrentFuel:{CurrentFuel}l");
        }
        public double Drive(double way)
        {
            if (way * FuelFor1Km > CurrentFuel)
            {
                Console.WriteLine("There is not enough gasoline.");
            }
            else
            {
                CurrentFuel = CurrentFuel-FuelFor1Km * way ;

            }
            return CurrentFuel;
        }
    }
}
