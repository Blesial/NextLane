using NextLane.Sección_2.Vehiculos_y_Automoviles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLane.Sección_2.Vehicle___Car
{
    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public Car(string brand, string model, int year, string fuelType)
            : base(brand, model, year)
        {
            FuelType = fuelType;
        }
        public double CalculateFuelEfficiency(double distance, double consumption)
        {
            if (consumption <= 0)
            {
                throw new ArgumentException("Consumption must be greater than zero.");
            }

            // Efficiency = Distance / Consumption
            return distance / consumption; // km/liter
        }

    }

}
    