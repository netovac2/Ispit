using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    class Desktop:Computer
    {
        public double CaseHeight { get; set; }

        public Desktop(string Model, string Manufacturer, string OperatingSystem, double caseHeight)
            :base(Model, Manufacturer, OperatingSystem)
        {
            CaseHeight = caseHeight;
        }

        public override string ToString()
        {
            return "DESKTOP   " + "Model: " + Model + ", " + "Manufacturer: " + Manufacturer + ", " + "OperatingSystem: " + OperatingSystem + ", " + "CaseHeight: " + CaseHeight;
        }
    }
}
