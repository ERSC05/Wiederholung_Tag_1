using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Crap
    {
        public int GroeßeC { get;  set; }
        public string NameC { get; private set; }
        public int SpeedC { get; private set; }
        public Crap(int groeßeC, string nameC, int speedC)
        {
            GroeßeC = groeßeC;
            NameC = nameC;
            SpeedC = speedC;
        }
        public void ErscheinenCrap(int[,] arr)
        {
             // Display the array elements.
             for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                        System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                 }
             }
            
        }
        /* Output:
            Element(0,0)=1
            Element(0,1)=2
            Element(1,0)=3
            Element(1,1)=4
            Element(2,0)=5
            Element(2,1)=6
            Element(3,0)=7
            Element(3,1)=8
        */
    }
}

