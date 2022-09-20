using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1nr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 99, 3, 7};

            Console.WriteLine("Wie viele Zahlen willst du hinzufügen?");
            int z = Convert.ToInt32(Console.ReadLine());
            int Anzahl = Convert.ToInt32(z);
            int u = -1;
            int a = 0;
            while (u < Anzahl)
            {
                if (u == 0)
                {
                    list.Add(91);
                    list.Add(92);
                    list.Add(93);

                    u = u + 1;
                }


                if (z != u)
                {
                
                    Console.WriteLine("Zahlen die du  hinzufügen willst?");
                    a = Convert.ToInt32(Console.ReadLine());
                    list.Add(a);
                    u = u + 1;
                }

            }
            list.RemoveAt(0);
            
            bool m = list.Any(x => x > 99);
            if (m)
            {
                list.RemoveAt();
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);

            }
            


            Console.ReadLine();


            
        }
    }
}
