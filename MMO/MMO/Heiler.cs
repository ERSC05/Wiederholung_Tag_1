using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    internal class Heiler : BasisClasse
    {
        public int Heilen { get; set; }
        

        public Heiler (int angreifH, int abwehr, int heilenH, int kassierenk, bool physisch)
        {
            Angriff = angreifH;
            Abwehren = abwehr;
            Kassieren = kassierenk;
            Physisch = physisch;
            Heilen = heilenH;
        }
    }
}
