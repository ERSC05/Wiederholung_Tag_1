using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Crap : Fish
    {
        public Crap(int x, int y)
        {
            Laenge = "<><";
            LaengeReversed = "><>";
            PosX = x;
            PosY = y;
            Richtung = "left";
            Hoeheaendert = 2;
            Richtungaendert = 50;
            Speed = 1;
        }
    }
}
