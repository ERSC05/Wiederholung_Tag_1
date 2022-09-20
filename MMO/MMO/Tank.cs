using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    internal class Tank : BasisClasse
    {
        

        public Tank(int angriff, int abwehren, int kassieren, bool physisch)
        {
            Angriff = angriff;
            Abwehren = abwehren;
            Kassieren = kassieren;
            Physisch = physisch;


        }
    }
}
