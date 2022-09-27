using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public class Schwertfisch : FishClass
    {
        public Schwertfisch(int x, int y)
        {
            Laenge = "-<><";
            LaengeReverse = "><>-";
            PosX = x;
            PosY = y;
            Richtung = "l";
            Hoeheaendert = 5;
            Richtungaendert = 50;
            Speed = 2;
        }
    }
}