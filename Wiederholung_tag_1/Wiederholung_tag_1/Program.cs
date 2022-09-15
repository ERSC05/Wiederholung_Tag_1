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
            Console.WriteLine("Sag mir einen Text mit ; ");
            string txt = Console.ReadLine();

            string[] splitted_txt = txt.Split(';');
            int laenge = txt.Length;


            for (int i = 0; i < laenge; i++)
            {
                Console.WriteLine(splitted_txt[i]);

            }
            Console.ReadLine();

            //jnakdjh; ahkagfahk; agkajg ; akl
        }
    }
}
