using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Kugelfisch : Fish
    {
        public Kugelfisch(int x, int y)
        {
            Laenge = "<()><";
            LaengeReversed = "><()>";
            PosX = x;
            PosY = y;
            Richtung = "left";
            Hoeheaendert = 10;
            Richtungaendert = 50;
            Speed = 1;
        }
    }
}
