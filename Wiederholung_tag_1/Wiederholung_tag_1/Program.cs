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
            // [  |    |    |   |   ]

            Console.WriteLine("Nenne die Größe vom int-Array");
            int Groese = Convert.ToInt32(Console.ReadLine());
            int[] zahlen = new int[Groese];

           

            
            for(int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("gebe mir eine Zahl für Array!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Deine Zahlen sind");
            Console.Write("[");

            for(int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($"{zahlen[i]} | ");
            }
            Console.Write("]");
            Console.ReadLine();

            Console.Write("Minimum und maximum sind hier:");
            Console.Write(" "zahlen.Min()+" , ");
            Console.Write(zahlen.Max());
            Console.ReadLine();




        }
    }
}
