using System;

namespace IGeographicalObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeographicalObject dnipro = new River(55.87, 33.72, "Dnipro", "One of the largest rivers in Europe", 80, 2201);
            IGeographicalObject hoverla = new Mountain(48.16, 24.50, "Hoverla", "The highest mountain in Ukraine", 2061);

            Console.WriteLine(dnipro.GetInfo());
            Console.WriteLine();
            Console.WriteLine(hoverla.GetInfo());
        }
    }
}