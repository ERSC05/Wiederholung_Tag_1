using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Class3Eck: IGeometry
    {
        public int Seite1 { get; set; }
        public int Seite2 { get; set; }
        //Hypotenuse
        public int Seite3 { get; set; }
        public Class3Eck(int seite1, int seite2, int seite3)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }

        public float Umfang()
        {
            return Seite1 + Seite2 + Seite3;
        }
        public float Flaeche()
        {
            return 2;
        }

    }
}
