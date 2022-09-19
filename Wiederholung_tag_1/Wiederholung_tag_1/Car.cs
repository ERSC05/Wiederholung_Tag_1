using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    public class Car
    {
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
}
