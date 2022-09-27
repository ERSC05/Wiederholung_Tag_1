using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Fish
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Richtung { get; set; }
        public string Laenge { get; set; }
        public string LaengeReversed { get; set; }
        public int Hoeheaendert { get; set; }
        public int Richtungaendert { get; set; }
        public int Speed { get; set; }
    }
}
