using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Shark
    {
        public int GroeßeSH { get; private set; }
        public string NameSH { get; private set; }
        public int SpeedSH { get; private set; }
        public Shark(int groeße, string name, int speed)
        {
            GroeßeSH = groeße;
            NameSH = name;
            SpeedSH = speed;
        }
    }
}
