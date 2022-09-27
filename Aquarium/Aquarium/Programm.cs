using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            /*Console.WriteLine("Das Aquarium erscheint in 5");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Das Aquarium erscheint in 4");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Das Aquarium erscheint in 3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Das Aquarium erscheint in 2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Das Aquarium erscheint in 1");
            Thread.Sleep(1000);*/

            Aquarium aquarium = new Aquarium(10, 50);
            
            aquarium.AddFish();
            aquarium.AquariumLeer();
            
            while (true)
            {
                Thread.Sleep(1000);
                aquarium.Schwimmen();
                aquarium.AquariumLeer();
            }
            Console.ReadLine();
            
        }
    }
}