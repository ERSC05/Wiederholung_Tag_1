using System;
using System.Collections.Generic;
using System.Globalization;
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
            int Pair = 0;
            int Ja = 0;

            Console.WriteLine("Drücke 1 um das spiel zu starten");
            Ja = Convert.ToInt32(Console.ReadLine());
            Random r = new Random(36);
            int gerade = r % 2;

            while (Ja == 1)
            {
                if (Pair == 1)
                {
                    if (r == gerade)
                    {
                        Console.WriteLine("DU gewinnst $20 bei deinem nächsten match")
                    }
                    else if (r == 0)
                    {
                        Console.WriteLine("Dein einsatz bleibt gleich")
                    }
                }

            }

            Console.ReadLine();
        }        
        
    }
}
