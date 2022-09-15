using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl ein");
            int Zahl = Convert.ToInt32(Console.ReadLine());
            //int a = 0;
            //int c = 0;
            int d = Zahl-1;


            for(int i = 0; i < Zahl; i++)
            {
                Console.WriteLine(d);
                d = d - 1;
            }

            
            

            Console.ReadLine();

            //jnakdjh; ahkagfahk; agkajg ; akl
        }
    }
}
