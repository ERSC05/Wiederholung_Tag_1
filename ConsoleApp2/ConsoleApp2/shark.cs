using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class shark : Fish
    {
        public shark(int x, int y)
        {
            Laenge = @"<////====><";
            LaengeReversed = @"><====\\\\>";
            PosX = x;
            PosY = y;
            Richtung = "left";
            Hoeheaendert = 4;
            Richtungaendert = 50;
            Speed = 5;
        }
    }
}
