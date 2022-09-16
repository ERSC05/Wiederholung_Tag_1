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

            Random random = new Random();
            int a = 1;
            bool Status = true;
            do
            {
                if ((a % 3 == 0) && (a % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    a = a + 1;
                }
                else if (a % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    a = a + 1;
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    a = a + 1;
                }

                else
                {
                    if (a <= 100)
                    {
                        Console.WriteLine(a);
                        a = a + 1;
                    }
                    else
                    {
                        Status = false;
                    }
                }
            } while (Status);

            
            
            Console.ReadLine();




        }
    }
}
