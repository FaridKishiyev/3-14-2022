using System;
namespace class_vehiclecar.Models
{
    public class Vehicle
    {
        public string Color;
        public int Year;

        public Vehicle(string Color, int Year)
        {
            this.Color = Color;
            this.Year = Year;
        }
        public Vehicle()
        {

        }
    }
}