﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sag mir einen Text mit Lehrzeichen ");
            string Text = Console.ReadLine();
            string OhneSpace = Text.Replace(" ", string.Empty);
            Console.WriteLine(OhneSpace);



            

            Console.ReadLine();


        }
    }
}
