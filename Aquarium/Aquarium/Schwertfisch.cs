using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Schwertfisch
    {
        public int GroeßeSC { get; private set; }
        public string NameSC { get; private set; }
        public int SpeedSC { get; private set; }
        public Schwertfisch(int groeße, string name, int speed)
        {
            GroeßeSC = groeße;
            NameSC = name;
            SpeedSC = speed;
        }
    }
}
