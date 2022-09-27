using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholungen
{
    public class Kreis : GeometrischeFormen
    {
        public Kreis(double radius, double seite1, double seite2) : base(radius, seite1, seite2)
        {
            double flaeceh = radius*radius*Math.PI;
            double umfang = 2 * Math.PI * radius;
            Console.WriteLine("Deine Flache vom Kreis ist" +" "+flaeceh);
            Console.WriteLine("Dein Umfang  com Kreis ist" + " " + umfang);
        }
        

        
    }

}
