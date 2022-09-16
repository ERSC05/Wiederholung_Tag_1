using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random_Zahl = r.Next(0, 10);
            Console.WriteLine("Sag mir einen Zahl. ");
            int Zahl = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            int c = 2;

                if (Zahl != random_Zahl)
                {
                    while(Zahl != random_Zahl)
                    {
                        if (Zahl <= random_Zahl)
                        {
                            Console.WriteLine("Random Zahl ist größer. erhöhe deinen guess")
                            Zahl = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Random Zahl ist kleiner. vermindere deinen Guess");
                            Zahl = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Du hast die richtige Zahl Glückwunsch!!!");
                    b = b + 1;
                }
            Console.WriteLine("Du hast die richtige Zahl Glückwunsch!!!");
            Console.ReadLine();
            
            
        }
    }
}
