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
            double Laenge = 0;
            double Breite = 0;
            double Hoehe = 0;
            string Roof = " ";
            string Farbe = " ";
            double Etage = 0;
            double Preis = 0;

            double BerechnungQM = GrundstückQM(Laenge, Breite);

            double BerechnungWF = hauswohnflaeche(Laenge, Breite, Hoehe);

            List<Haus>Wohnung = new List<Haus>();


            Console.WriteLine("Gib die Länge des Hauses an");
            Laenge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die Breite des Hauses an");
            Breite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die höhe des Hauses an");
            
            Hoehe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die Dachart des Hauses an");
            Roof = Console.ReadLine();
            Console.WriteLine("roof farbe");
            Farbe = Console.ReadLine();
            Console.WriteLine("anzahl der Etagen");
            Etage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Preis");
            Preis = Convert.ToInt32(Console.ReadLine());


            BerechnungQM = GrundstückQM(Laenge, Breite);
            hauswohnflaeche(Laenge, Breite, Hoehe);
            Haus h1 = new Haus(Laenge, Breite, Hoehe, Roof, Farbe, Etage, Preis, BerechnungQM, BerechnungWF);
            Wohnung.Add(h1);
            // Farbe ändern
            Console.WriteLine("Willst du die Farbe des Hauses ändern?");
            
            string u = Console.ReadLine();
            if (u == "y")
            {
                Console.WriteLine("Welche farbe willst du haben?");
                Farbe = Console.ReadLine();
                Haus h2 = new Haus(Laenge, Breite, Hoehe, Roof, Farbe, Etage, Preis, BerechnungQM, BerechnungWF);
                Console.WriteLine("Welche farbe willst du haben?");            

                Wohnung.Add(h2);
            }
            else
            {
                Console.WriteLine("Foherige Wohnung");
                foreach (Haus a in Wohnung)
                {
                    a.PrintHausInformation();
                }
            }

            
           
            
            
                        








            Console.ReadLine();
        }  
        static double GrundstückQM(double f, double b)
        {
            double QM = f* b;
            return QM;
        }
        static double hauswohnflaeche(double f, double b, double h)
        {
            double flaeche = f * b * h;
            return flaeche;
        }


    }

    


    
}
