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
            Console.WriteLine("Wir holen uns eine Zahl aus Numer()");
            List<string> names = Number();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.ReadLine();
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
