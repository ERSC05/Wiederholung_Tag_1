using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Kugelfisch
    {
        public int GroeßeK { get; private set; }
        public string NameK { get; private set; }
        public int SpeedK { get; private set; }
        public Kugelfisch(int groeße, string name, int speed)
        {
            GroeßeK = groeße;
            NameK = name;
            SpeedK = speed;
        }
    }
}
