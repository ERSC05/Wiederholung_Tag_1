﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public class Shark : FishClass
    {
        public Shark(int x, int y)
        {
            Laenge = @"<////====><";
            LaengeReverse = @"><====\\\\>";
            PosX = x;
            PosY = y;
            Richtung = "l";
            Hoeheaendert = 4;
            Richtungaendert = 50;
            Speed = 5;
        }
        
    }
}