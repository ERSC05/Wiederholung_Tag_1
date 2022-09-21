using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Car
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Farbe { get; set; }
        public int Geschwindigkeit { get; set; }
        public bool MotorAn { get; set; }
        public Car(int typeId, string make, string model, string typeName, string farbe, int geschwindigkeit, bool motoran)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            Farbe = farbe;
            Geschwindigkeit = geschwindigkeit;
            MotorAn = motoran;


        }

        public void Starten()
        {
            if (MotorAn == true)
            {
                Console.WriteLine("Motor Läuft gereits");
            }
            else
            {
                Console.WriteLine("Motur wird gestartet");
                MotorAn = true;
                //Thread.Sleep(200);
            }
        }
        public void Bremsen()
        {
            if (MotorAn == true)
            {
                Console.WriteLine("Wie viel willst du bremsen?");
                Geschwindigkeit = Geschwindigkeit - Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Du bist am bremsen");
                Console.WriteLine($"Deine Geschwindigkeit beträgt: {Geschwindigkeit}");

            }
            else
            {
                Console.WriteLine("Motor muss noch getsartet werden");
            }
        }
        public void Beschleunigen()
        {
            if (MotorAn == true)
            {
                if (Geschwindigkeit >= 20)
                {
                    Console.WriteLine("Bremsen!!!!");
                    Geschwindigkeit = Geschwindigkeit - 10;
                    //Thread.Sleep(2000);
                    Console.WriteLine($"Deine Geschwindigkeit beträgt: { Geschwindigkeit}");
                }
                else
                {

                    Geschwindigkeit++;
                    Console.WriteLine($"Geschwindigkeit des Autos beträgt: {Geschwindigkeit}");
                    //Thread.Sleep(100);
                }
            }
            else
            {
                Console.WriteLine("Motor muss noch gestarten werden");
            }
        }
            
            
            
        
        
    }
}
