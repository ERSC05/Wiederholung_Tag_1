using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Aquarium
    {
        public int Hoehe { get; set; }
        public int Breite { get; set; }
        public Random Random { get; set; }
        public string[,] Content { get; set; }
        public List<Fish> Fische { get; set;}
        public Aquarium(int breite, int height)
        {
            Breite = breite;
            Hoehe = height;
            Content = new string[Breite, Hoehe];
            Fische = new List<Fish>();
            Random = new Random();
        }
    }
    public void AquariumLeer()
    {
        public void AquariumLeer()
        {
            for (int j = 0; j < Content.GetLength(0); j++)
            {
                for (int i = 0; i < Content.GetLength(1); i++)
                {
                    Content[j, i] = "-";

                    if (j == Content.GetLength(0) - 1 && (i == Content.GetLength(1) - 1 || i == 0))
                    {
                        Content[j, i] = "|";
                    }
                    else if (i == 0 || i == Content.GetLength(1) - 1)
                    {
                        Content[j, i] = "|";
                    }
                    else if (j == Content.GetLength(0) - 1)
                    {
                        Content[j, i] = "_";
                    }
                }
            }
            //Fische erzeugen und ins aquarium
            foreach (FishClass fish in Fishes)
            {
                int y = fish.PosY;
                string Laenge = fish.Laenge;
                if (fish.Richtung == "right")
                {
                    y -= Laenge.Length - 1;

                    Laenge = fish.LaengeReverse;
                }


                foreach (char c in Laenge)
                {
                    Content[fish.PosX, y] = Char.ToString(c);
                    y++;
                }
            }
            PrintAquarium();
        }
    }
}
