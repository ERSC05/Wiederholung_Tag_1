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
            int b = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int c = 0;
            int d = 0;


            while(a != b)
            {
                c = c + a;
                a = a + 1;
                Console.WriteLine(c);
            }
            

            Console.ReadLine();

            //jnakdjh; ahkagfahk; agkajg ; akl
        }
    }
}
