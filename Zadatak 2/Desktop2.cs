using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class Desktop : Computer
    {
       
            public double CaseHeight { get; set; }

            public Desktop(string Model, string Manufacturer, string OperatingSystem, double caseHeight)
                : base(Model, Manufacturer, OperatingSystem)
            {
                CaseHeight = caseHeight;
            }

        public override string getComputerType()
        {
            return $"DESKTOP   Model: {Model} Manufacturer: {Manufacturer} Operating System: {OperatingSystem} Case Height: {CaseHeight}";
        }


        public override int calculatePortabilityScore()
        {
            
            double x1 = 5d;
            int portabilityScore1 = (int)(x1 + (CaseHeight / 30));
            {
                return portabilityScore1;
            }
        }



    }
}
