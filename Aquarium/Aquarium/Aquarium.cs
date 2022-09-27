using Aquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aquarium
{
    public class Aquarium
    {
        public int Hoehe { get; set; }
        public int Breite { get; set; }
        public Random Random { get; set; }
        public string[,] Content { get; set; }
        public List<FishClass> Fishes { get; set; }
        public List<Shark> Sharks { get; set; }
        public Aquarium(int breite, int height)
        {
            Breite = breite;
            Hoehe = height;
            Content = new string[Breite, Hoehe];
            Fishes = new List<FishClass>();
            Random = new Random();
        }

        public void AquariumLeer()
        {
            for (int j = 0; j < Content.GetLength(0); j++)
            {
                for (int i = 0; i < Content.GetLength(1); i++)
                {
                    Content[j, i] = "~";


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
                if (fish.Richtung == "r")
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
        //Aquarium print
        private void PrintAquarium()
        {
            Console.Clear();
            for (int i = 0; i < Content.GetLength(0); i++)
            {
                for (int j = 0; j < Content.GetLength(1); j++)
                {
                    if (Content[i, j] == "~")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }


                    Console.Write(Content[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("\n");
            }
        }

        public void AddFish()
        //inizialisierung der Fische
        {
            Fishes.Add(new Carp(4, 5));
            Fishes.Add(new Shark(6, 19));
            Fishes.Add(new Kugelfisch(8, 15));
            Fishes.Add(new Schwertfisch(3, 15));
            Fishes.Add(new Mantarochen(1, 14));
        }
        public void AddFish2()
        //inizialisierung der zweiten Fische
        {
            Fishes.Add(new Carp(40, 50));
            Fishes.Add(new Shark(35, 20));
            Fishes.Add(new Kugelfisch(35, 15));
            Fishes.Add(new Schwertfisch(30, 15));

        }

        public void Schwimmen()
        {
            foreach (FishClass fish in Fishes)
            {
                fish.Schwimmen(this);
            }
        }
        public void Fressen(FishClass fishClass)
        {

            foreach (FishClass fish in Fishes)
            {
                if (fish.GetType().Name == "Shark")
                {
                    int a = fish.GetType().GenericParameterPosition;
                    Console.WriteLine(a);

                    if (fish.GetType().Name == "Crap")
                    {
                        int b = fish.GetType().GenericParameterPosition;
                        Console.WriteLine(b);
                    }
                }
            }

        }
    }
}