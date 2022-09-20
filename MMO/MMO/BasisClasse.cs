using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    internal class BasisClasse
    {
        
        public int Angriff { get; set; }
        public int Abwehren { get; set; }
        public int Kassieren { get; set; }
        public bool Physisch { get; set; }
        public bool Achtung_Angriff { get; set; }
       
        public void Attac(BasisClasse attack_Carakter)
        {
            this.GetType();

            Console.WriteLine("Mit wie viel GP willst du spielen?");
            int GP = Convert.ToInt32(Console.ReadLine());
            

            if (GP > 0)
            {



                if (Achtung_Angriff == true)
                {
                    Console.Write("Mit wem willst du Angreifen? |  Tank  |  Healer  |  Fernkämpfer  |");
                    string AngriffaArt = Console.ReadLine();
                    if (AngriffaArt == "Tank")
                    {
                        this.GetType();
                        GP = GP - Angriff;
                        if (Physisch == true)
                        {
                            Console.WriteLine("Das war ein PHYSISCHER ANGRIFF AAAAAUUUUUAAAAAAA");
                            Console.WriteLine("Deine GP sind" + GP);
                            Console.WriteLine("Der Computer ist am Zug");

                        }
                        else
                        {
                            Console.WriteLine("DAS WAR EIN MAGISCHER ANGRIFF AAAAAAAAAAUUUUUUUUUUUUUUUUAAAAAAAAAAAAAA");
                            Console.WriteLine("Deine Gb sind" + GP);
                            Console.WriteLine("Der Computer ist am Zug");



                        }
                    }
                    else if (AngriffaArt == "Healer")
                    {
                        this.GetType();
                        GP = GP - Angriff;
                        if (Physisch == true)
                        {
                            Console.WriteLine("Das war ein PHYSISCHER ANGRIFF AAAAAUUUUUAAAAAAA");
                            Console.WriteLine("Deine GP sind" + GP);
                            Console.WriteLine("Der Computer ist am Zug");

                        }
                        else
                        {
                            Console.WriteLine("DAS WAR EIN MAGISCHER ANGRIFF AAAAAAAAAAUUUUUUUUUUUUUUUUAAAAAAAAAAAAAA");
                            Console.WriteLine("Deine Gb sind" + GP);
                            Console.WriteLine("Der Computer ist am Zug");


                        }


                    }
                    else if (AngriffaArt == "Fernkämpfer")
                    {
                        //this.GetType().Name;
                        GP = GP - Angriff;
                        if (Physisch == true)
                        {
                            Console.WriteLine("Das war ein PHYSISCHER ANGRIFF AAAAAUUUUUAAAAAAA");
                            Console.WriteLine("Deine GP sind" + GP);
                            Console.WriteLine("Der Computer ist am Zug");
                        }
                        else
                        {
                            Console.WriteLine("DAS WAR EIN MAGISCHER ANGRIFF AAAAAAAAAAUUUUUUUUUUUUUUUUAAAAAAAAAAAAAA");
                            Console.WriteLine("Deine Gb sind" + GP);
                            Console.WriteLine("Der Computer ist am Zug");


                        }
                    }

                }
                else
                {
                    Console.WriteLine("Wir spielen dann eben kein spiel :(");
                }

            }
            else
            {
                Console.WriteLine("Du hast keine GP mehr. Du hast verlohren");
            }           
        }
    }
    
}
