using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Achtung_Angriff = false;
            List<BasisClasse>Panzer = new List<BasisClasse>();
            

            Panzer.Add(new Tank(10, 15, -5, true));

            List<BasisClasse> Healer = new List<BasisClasse>();

            

            Healer.Add(new Heiler(4, 5, 20, -7, false));

            List<BasisClasse> Archer = new List<BasisClasse>();
            

            Archer.Add(new Fernkaempfer(6, 6, -6, true));



            Console.WriteLine("Um das epische Spiel zu starten, drücke die 1");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mit wie viel GP willst du spielen?");
            int GP = Convert.ToInt32(Console.ReadLine());

            

        }
    }
}
