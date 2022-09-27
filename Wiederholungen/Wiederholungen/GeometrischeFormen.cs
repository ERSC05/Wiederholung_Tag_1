using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholungen
{
    public abstract class GeometrischeFormen
    {
        public double Radius { get; set; }
        public double Seite1 { get; set; }
        public double Seite2 { get; set; }

        public GeometrischeFormen(double radius, double seite1, double seite2)
        {
            Radius = radius;
            Seite1 = seite1;
            Seite2 = seite2;
        }
    }
}
