using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dreieck d = new Dreieck(0, 0, 0);
            Console.WriteLine("Gebe einen Radius ein");
            Kreis r = new Kreis(Convert.ToDouble(Console.ReadLine()), 0, 0);
            Console.WriteLine("Gebe eine Seite ein");
            d.Seite1 =  4;
            Console.WriteLine("Gebe eine weiter Seie ein");
            d.Seite2 = 5;




            double Radius = Convert.ToDouble(Console.ReadLine());
            List<GeometrischeFormen> geometrischeFormens = new List<GeometrischeFormen>();
            geometrischeFormens.Add(r);
            geometrischeFormens.Add(d);


            Console.WriteLine();
            Console.ReadLine();
            

        }
    }
}
