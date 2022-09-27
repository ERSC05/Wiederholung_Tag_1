using Aquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public abstract class FishClass
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Richtung { get; set; }
        public string Laenge { get; set; }
        public string LaengeReverse { get; set; }
        public int Hoeheaendert { get; set; }
        public int Richtungaendert { get; set; }
        public int Speed { get; set; }

        
        public void Schwimmen(Aquarium aquarium)
        {
            // Fische änderen die Höhe
            RichtungAendern(aquarium, Richtungaendert);
            HoehenWaechsel(aquarium, Hoeheaendert);
            
            if (Richtung == "l")
            {
                //nicht gegen Wände schwimmen
                if (Laenge.Length >= PosY - Speed)
                {
                    Richtung = "r";
                    PosY = Laenge.Length;
                }
                else
                {
                    PosY -= Speed;
                }
            }
            else
            {
                if (Laenge.Length >= (aquarium.Content.GetLength(1) - PosY + Speed))
                {//Wände vermeiden
                    Richtung = "l";
                    PosY = aquarium.Content.GetLength(1) - 1 - Laenge.Length;
                }
                else
                {//gearde aus schwimmen
                    PosY += Speed;

                }
            }
        }
        public void RichtungAendern(Aquarium aquarium, int probability)
        {
            if (aquarium.Random.Next(0, probability) == 1)
            {
                if (Richtung == "l")
                {
                    Richtung = "r";
                    PosY += Laenge.Length;
                }
                else
                {
                    Richtung = "l";
                    PosY -= Laenge.Length;
                }
            }
        }
        public void HoehenWaechsel(Aquarium aquarium, int probability)
        {
            if (aquarium.Random.Next(0, probability) == 1)
            {
                if (aquarium.Random.Next(0, 2) == 1 && PosX - 1 >= 0)
                {
                    PosX -= 1;
                }
                else if (PosX + 1 < aquarium.Content.GetLength(0) - 1)
                {
                    PosX += 1;
                }
            }
        }
        public void Fressen(FishClass Crap)
        {
            if (typeof(Shark).ToString() == "Shark")
            {
                string a = Convert.ToString(GetType());
                if (Crap.Laenge == "<><")
                {
                    List<string> list = new List<string>();
                    list.Add("<><");
                    
                }
            }
        }
    }
}