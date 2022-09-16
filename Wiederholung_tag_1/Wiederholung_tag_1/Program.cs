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
            Console.WriteLine("Nenne mir eine Zahl");
            double zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nenne mir eine weitere Zahl");
            double zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nenne mir einen Opperrator");
            string operrator = Console.ReadLine();
            double sum = zahl1 + zahl2;
            double sup = zahl1 - zahl2;
            double pro = zahl1 * zahl2;
            double div = zahl1 / zahl2;
            double mod = zahl1 % zahl2;

            

            switch (operrator)
            {
                case "+":
                    Console.WriteLine(zahl1+"+"+zahl2+"="+sum);
                    break;
                case "-":
                    Console.WriteLine(zahl1 + "-" + zahl2 + "=" +sup);
                    break;
                case "*":
                    Console.WriteLine(zahl1 + "*" + zahl2 + "=" + pro);
                    break;
                case "/":
                    Console.WriteLine(zahl1 + "/" + zahl2 + "=" + div);
                    break;
                case "%":
                    Console.WriteLine(zahl1 + "%" + zahl2 + "=" + mod);
                    break;

                default:
                    Console.WriteLine("das war kein opperrater >:(");
                        break;
            }


            Console.ReadLine();



        }
    }
}
