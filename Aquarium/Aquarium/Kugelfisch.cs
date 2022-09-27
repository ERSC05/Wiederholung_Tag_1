﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public class Kugelfisch : FishClass
    {
        public Kugelfisch(int x, int y)
        {
            Laenge = "<()><";
            LaengeReverse = "><()>";
            PosX = x;
            PosY = y;
            Richtung = "l";
            Hoeheaendert = 10;
            Richtungaendert = 50;
            Speed = 1;
        }
    }
}