using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pair = 1;
            int Ja = 0;

            Console.WriteLine("Drücke 1 um das spiel zu starten");
            Ja = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int gerade = 2;
            int ungerade = 1;
            int t = 2;
            int k = r.Next(0, 37);
            int guthaben = 10000;
            

            //            int mod = 2;

            if (Ja == 1)
            {
                Pair = k;

                switch (Pair)
                {
                    case 1:
                        t = gerade;
                        Console.WriteLine("dein Gewinn erhöt sich");
                        break;
                    case 2:
                        t = ungerade;
                        Console.WriteLine("Dein einsatz bleibt bestehen");
                        break;
                    case 3:
                        t = 0;
                        Console.WriteLine("Du hast dein Einsatzt verloren");
                        break;
                    default:
                        Console.WriteLine(r);
                        break;


                }
                
            }
            else
            {
                Console.WriteLine("dann gibt es kein spiel");
            }
            Console.ReadLine();
        }        
        
    }
}
