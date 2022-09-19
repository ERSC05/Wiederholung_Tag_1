using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Wiederholung_tag_1
{
    public class Car
    {
        //Car
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }  
        public string Color { get; set; }
        public int CCM { get; set; }
        public int Reifen { get; set; }


        public Car(int typeId, string make, string model, string typeName, string color, int ccm, int reifen)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
            CCM = ccm;
            Reifen = reifen;
        }


        public void PrintCarInformation()
        {
            Console.WriteLine("mein Fahrzeug ist "  + " " + Model + " " + TypeName + "mit einem Hubraum von" + TypeId + "in der Farbe" + Color + "mit den reifen");
        }
    }
    public class Haus
    {
        public double Laenge { get; set; }
        public double Breite { get; set; }
        public double Hoehe { get; set; }
        public string Roof { get; set; }
        public string Farbe { get; set; }
        public double Etage { get; set; }
        public double Preis { get; set; }
        public double BerechnungQM { get; set; }
        public double BerechnungWF { get; set; }

        public Haus(double laenge, double breite, double hoehe, string roof, string farbe, double etage, double preis, double berechnungQM, double berechnungWF)
        {
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            Roof = roof;
            Farbe = farbe;
            Etage = etage;
            Preis = preis;
            BerechnungQM = berechnungQM;
            BerechnungWF = berechnungWF;
        }
        public void PrintHausInformation()
        {
            Console.WriteLine("Laenge: "+Laenge);
            Console.WriteLine("Breite: "+Breite);
            Console.WriteLine("Dachart: "+Roof);
            Console.WriteLine("Farbe: "+Farbe);
            Console.WriteLine("Etage: "+Etage);
            Console.WriteLine("Preis: "+Preis);
            Console.WriteLine("QM: " + BerechnungQM);
            Console.WriteLine("WF: " + BerechnungWF);

        }
    }


}
