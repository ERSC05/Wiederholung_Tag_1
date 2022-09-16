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
            List<string> namen = new List<string>();
            Console.WriteLine("Wie viele namen willst du aufzählen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine("Nenne einen Namen");
                namen.Add(Console.ReadLine());
                Console.WriteLine(namen[i]);
            }
            Console.WriteLine("Okay das sind also deinen Namne:");

            for (int i = 0; i < namen.Count; i++)
            {
                Console.Write(namen[i]+" | ");

            }
            Console.ReadLine();


        }
    }
}
