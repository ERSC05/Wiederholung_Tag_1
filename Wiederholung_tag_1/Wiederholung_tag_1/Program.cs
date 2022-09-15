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
            Console.WriteLine("Sag mir eine Zahl. ");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Sag mir noch eine Zahl: ");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());

            decimal Ergebnis = number1 + number2;

            Console.WriteLine(number1 +" + "+number2 + " + "+Ergebnis);




            Console.WriteLine();
            
            
            
 /*           int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sage mir eine weitere Zahl ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            int Ergebnis = Zahl1 + Zahl2;
            Console.WriteLine(Zahl1+" + "+Zahl2+" = "+Ergebnis);
 */

            Console.ReadLine();


        }
    }
}
