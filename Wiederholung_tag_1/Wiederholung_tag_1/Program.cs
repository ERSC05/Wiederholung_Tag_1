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
            Console.WriteLine("Sag mir einen Text. U und G wird vertauscht. ");
            string Text = Console.ReadLine();
            string TextAnders = Text.Replace('U', 'G').Replace('u', 'g');
            
             

            Console.WriteLine(TextAnders);
            
            
            
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
