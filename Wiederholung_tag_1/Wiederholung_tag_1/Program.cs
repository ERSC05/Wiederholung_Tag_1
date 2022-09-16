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
            List<int> list1 = new List<int>() {5, 3, 7};
            string space = Console.ReadLine();
            string n = Console.ReadLine();
            
            do
            {
                Console.WriteLine("füge zahlen hinzu ");
                list1.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("willst du noch eine andere Zahl hinzufügen? ");
                if (n == "n")
                {
                    Console.WriteLine("Füge weitere Zahlen hinzu");
            
                
                }
            } while (Console.ReadLine() != "n");

            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }        
        
    }
}
