using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class Laptop : Computer
    {
        public int BatteryCapacity { get; set; }
        public double Weight { get; set; }


        public Laptop(string Model, string Manufacturer, string OperatingSystem, int batteryCapacity, double weight)
            : base(Model, Manufacturer, OperatingSystem)
        {
            BatteryCapacity = batteryCapacity;
            Weight = weight;
        }


        public override string getComputerType()
        {
            return $"LAPTOP   Model: {Model} Manufacturer: {Manufacturer} Operating System: {OperatingSystem} Battery Capacity: {BatteryCapacity} Weight: {Weight}";
        }

        public override int calculatePortabilityScore()
        {
            int portabilityScore = (int)Weight;
            {
                return portabilityScore;
            }

            


        }
    }
}
