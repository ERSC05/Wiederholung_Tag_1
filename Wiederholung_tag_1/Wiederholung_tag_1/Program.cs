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
            string[] namen = new string[13];
            string[] namen2 = new string[] { "Lukas", "Jonas", "Mona", "Marie", "Phillip", "Erwin", "Leon", "Marcello", "Johannes", "Robin", "Andreas", "Robert" };

            for (int i = 0; i < namen2.Length; i++)
            {
                namen2[i] += "      123";
            }

            foreach (string trainiee in namen2)
            {

                Console.WriteLine(trainiee);

            }
            Console.ReadLine();
            
            
        }
    }
}
