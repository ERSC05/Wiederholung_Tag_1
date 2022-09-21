using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FishClass
    {
        
        public int Groeße { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public FishClass(int groeße, string name, int speed)
        {
            Groeße = groeße;
            Name = name;
            Speed = speed;
        }
        void REPrintArray(int[] arr)
        {

            //Aquarium reprint
            string[,] aquarium = new string[10, 10];
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == 0)
                    {
                        aquarium[i, j] = "|";
                    }
                    else if (i >= 9)
                    {
                        aquarium[i, j] = "|";
                    }
                    else if (j >= 9)
                    {
                        aquarium[i, j] = "_";
                    }
                    else
                    {
                        aquarium[i, j] = "a";

                    }

                }
            }
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(aquarium[i, j]);
                }
                Console.Write("\n");
            }

        }
    }
    
}
