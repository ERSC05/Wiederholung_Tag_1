using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Mime;
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
            Class3Eck d = new Class3Eck(2, 4, 10);

            Circle c = new Circle(5);

            Recheck r = new Recheck(10, 20);

            List<IGeometry> geometries = new List<IGeometry>();


            geometries.Add(d);
            geometries.Add(c);
            geometries.Add(r);

            foreach(IGeometry g in geometries)
            {
                Console.WriteLine("mein " + g.GetType().Name + " hat eine Fläche von " + g.Umfang() + " Und den Umfang von " + g.Flaeche());
            }



            Console.ReadLine();
        }  
        


    }
    
    


    
}
