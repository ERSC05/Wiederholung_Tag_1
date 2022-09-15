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
            Console.WriteLine("Sag mir einen Buchstaben. ");
            string Buchstabe = Console.ReadLine();
            string Text = ("Jan, Erwin, Marcello, Phillip, Lukas, Robert, Robin, Jonas, Marie, Mona, Hannes, Andreas, Christian");
            string[] List = Text.Split(',');

            foreach (string s in List)
            {
                if (s.Contains(Buchstabe))
                {
                    Console.WriteLine(s);
                }
                    
            }
            



            Console.ReadLine();
        }
    }
}
