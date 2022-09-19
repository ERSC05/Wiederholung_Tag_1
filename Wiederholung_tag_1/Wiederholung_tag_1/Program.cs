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
            Console.WriteLine("Wie viele Autos willst du in die Liste anlegen?");

            
            int AutoZahl = Convert.ToInt32(Console.ReadLine());
            int TypeId = 0;
            string Make = "0";
            string Model = "0";
            string Color = "0";
            string typeName = "0";
            int CCM = 0;
            int Reifen = 0;
            int f = 0;



            List<Car> cars = new List<Car>() {};
            while (AutoZahl != f)
            {
                Console.WriteLine("gib eine TypeId an");
                TypeId = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Make eingeben");
                Make = Console.ReadLine();
                Console.WriteLine("Model eingeben");
                Model = Console.ReadLine();
                Console.WriteLine("typeName eingeben");
                typeName = Console.ReadLine();
                Console.WriteLine("Color eingeben");
                Color = Console.ReadLine();
                Console.WriteLine("ccm eingeben");
                CCM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Reifen anzahl");
                Reifen = Convert.ToInt16(Console.ReadLine());


                f = f + 1;
                Car c = new Car(TypeId, Make, Model, typeName, Color, CCM, Reifen);
                cars.Add(c);


            }
            foreach(Car car in cars)
            {
                car.PrintCarInformation();
            }
            

            

/*            List<string> Tags = new List<string>(4);

            List<Car> cars = new List<Car>();

            foreach(Car car in cars)
            {
                
                car.PrintCarInformation();
            }  
*/            Console.ReadLine();
        }        
        
    }

    
}
