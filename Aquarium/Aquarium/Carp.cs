using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public class Carp : FishClass
    {
        public Carp(int x, int y)
        {
            Laenge = "<><";
            LaengeReverse = "><>";
            PosX = x;
            PosY = y;
            Richtung = "l";
            Hoeheaendert = 2;
            Richtungaendert = 50;
            Speed = 1;
        }
    }
}