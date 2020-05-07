using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows Printer;

            Console.WriteLine("\t=================");
            Console.WriteLine("\t| Jenis Printer |");
            Console.WriteLine("\t=================");
            Console.WriteLine("\t| 1. Canon      |");
            Console.WriteLine("\t| 2. Epson      |");
            Console.WriteLine("\t| 3. Laser Jet  |");
            Console.WriteLine("\t=================\n");
            Console.Write("\tPilihan Printer (1-3) : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            if (pilihPrinter == 1)
                Printer = new Canon();
            else if (pilihPrinter == 2)
                Printer = new Epson();
            else
                Printer = new LaserJet();

            Printer.Show();
            Printer.Print();

            Console.ReadKey();


        }
    }
}
