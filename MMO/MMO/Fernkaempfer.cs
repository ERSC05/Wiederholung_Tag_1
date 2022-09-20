using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    internal class Fernkaempfer : BasisClasse
    {

        public Fernkaempfer (int angriffF, int abwehrF, int kassieren, bool physisch)
        {
            Angriff = angriffF;
            Abwehren = abwehrF;
            Kassieren = kassieren;
            Physisch = physisch;
            //this.GetType().Name {Name}

        }
    }
}
