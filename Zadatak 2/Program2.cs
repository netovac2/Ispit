using System;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("D928", "HP", "Windows 10", 10000, 1.5);
            Desktop desktop = new Desktop("fkj", "Samsung", "Windows 10", 22.5);

            Console.WriteLine(laptop.getComputerType());
            Console.WriteLine(desktop.getComputerType());

            Console.WriteLine('\n');

            Console.WriteLine("Laptop Portability Score is: " + laptop.calculatePortabilityScore());
            Console.WriteLine("Desktop Portability Score is: " + desktop.calculatePortabilityScore());
        }



        
    }
}
