using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    class Laptop:Computer
    {
        public int BatteryCapacity { get; set; }
        public double Weight { get; set; }


        public Laptop(string Model, string Manufacturer, string operatingSystem, int batteryCapacity, double weight)
            :base(Model, Manufacturer, operatingSystem)
        {
            BatteryCapacity = batteryCapacity;
            Weight = weight;
        }

        public override string ToString()
        {
            return "LAPTOP   " + "Model: " + Model + ", " + "Manufacturer: " + Manufacturer + ", " + "OperatingSystem: " + OperatingSystem + ", " + "Battery Capacity: " + BatteryCapacity + ", " + "Weight: " + Weight;
        }

    }


    
}

