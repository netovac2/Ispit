using System;

namespace Ispit
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer("xyz", "Dell", "Windows 10");
            Laptop laptop = new Laptop("D928", "HP", "Windows 10", 10000, 1.5);
            Desktop desktop = new Desktop("fkj", "Samsung", "Windows 10", 22.5);

            Console.WriteLine(computer.ToString());
            Console.WriteLine('\n');
            Console.WriteLine(laptop.ToString());
            Console.WriteLine('\n');
            Console.WriteLine(desktop.ToString());

           
        }
    }
}
