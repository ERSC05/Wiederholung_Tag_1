using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Recheck :IGeometry
    {
        public int seite1 { get; set; }
        public int seite2 { get; set; }
        public Recheck(int seite1, int seite2)
        {
            this.seite1 = seite1;
            this.seite2 = seite2;
        }

        public float Flaeche()
        {
            return seite1 * seite2;
        }
        public float Umfang()
        {
            return 2 * (seite1 + seite2);
        }
    }
}
