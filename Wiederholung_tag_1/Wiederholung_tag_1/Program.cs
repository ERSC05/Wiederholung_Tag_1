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
            Console.WriteLine("Sag mir einen Text. ");
            string Text = Console.ReadLine();
            Console.WriteLine(Text.PadLeft(20, 'y'));
            Console.WriteLine(Text.PadRight(30, 'y'));




            Console.ReadLine();
        }
    }
}
