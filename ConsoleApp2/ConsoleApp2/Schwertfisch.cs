using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Schwertfisch : Fish
    {
        public Schwertfisch(int x, int y)
        {
            Laenge = "-<><";
            LaengeReversed = "><>-";
            PosX = x;
            PosY = y;
            Richtung = "left";
            Hoeheaendert = 5;
            Richtungaendert = 50;
            Speed = 2;
        }
    }
}
