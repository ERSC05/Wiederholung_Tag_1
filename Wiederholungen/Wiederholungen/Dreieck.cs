using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholungen
{
    internal class Dreieck : GeometrischeFormen
    {
        public Dreieck(double radius, double seite1, double seite2) : base(radius, seite1, seite2)
        {
            double flaeche = seite1 * seite2;
            double umfang = seite1 * 2 + seite2 * 2;
            //Console.WriteLine("Deine Flache vom Dreieck ist" + " " + flaeche);
            //Console.WriteLine("Dein Umfang vonm Dreieck ist" + " " + umfang);
        }
    }
}
