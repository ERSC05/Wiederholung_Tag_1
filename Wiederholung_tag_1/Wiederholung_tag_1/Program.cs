using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wiederholung_tag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();


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


            List<Vehicle> fahrzeuge = new List<Vehicle>();
            fahrzeuge.Add(new Motorcycle1(123, "bmw", "sheeesh", "geilomart", 4 , "blau"));
            fahrzeuge.Add(new Car(123, "vw", "sheeesh", "geilomart", 10, "yellow"));

            foreach(Vehicle v in fahrzeuge)
            {
                v.Starten();
                v.Beschleunigen();
                v.Beschleunigen();
                v.Bremsen();
                v.Starten();
                v.Bremsen();
                v.Bremsen();
            }

            Console.ReadLine();
        }  
        


    }
    
    


    
}
