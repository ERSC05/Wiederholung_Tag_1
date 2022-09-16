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
            Console.WriteLine("gebe ein zahl ein");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gebe eine weitere Zahl ein");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int ergebnis = Add(zahl1, zahl2);
            Console.WriteLine(ergebnis);

            ergebnis = divide(zahl1, zahl2);
            Console.WriteLine(ergebnis);

            ergebnis = subtra(zahl1, zahl2);
            Console.WriteLine(ergebnis);

            ergebnis = multi(zahl1, zahl2);
            Console.WriteLine(ergebnis);

            Console.ReadLine();
        }

        static int Add(int z1, int z2)
        {
            int summe = z1 + z2;
            return summe;
        }
        static int divide(int z1, int z2)
        {
            int div = z1 / z2;
            return div;
        }

        static int subtra(int z1, int z2)
        {
            int sub = z1 - z2;
            return sub;
        }
        static int multi(int z1, int z2)
        {
            int mult = z1 * z2;
            return mult;
        }
        


        //static Rückgabetyp Methodenname (Parameter)
        static List<string> Number()
        {
            List<string> name = new List<string>();
            name.Add("ABD");

            //Rückgabevariable
            return name;
        }
    }
}
