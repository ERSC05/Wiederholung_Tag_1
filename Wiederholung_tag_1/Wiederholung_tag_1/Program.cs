using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.TypeId = 13494;
            c1.make = "VW";
            c1.Model = "vw gti";
            c1.TypeName = 5;
            c1.Color = "red";

            Console.ReadLine();
        }        
        
    }

    
}
