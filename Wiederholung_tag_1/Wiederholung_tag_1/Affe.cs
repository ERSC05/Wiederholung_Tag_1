using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    public class Affe
    {
        public string Name { get; set; }
        public string Essen { get; set; }
        public string Trinken { get; set; }
        public int Alter { get; set; }
        public int Lebensdauer { get; set; }
        public string Groeße { get; set; }
        public float Gewicht { get; set; }
        public string Gerausche { get; set; }
        public string Fell { get; set; }



        public Affe(string essen, string trinken, string gerausche, string name, int alter, string groese, int lebensdauer, float gewicht, string fell)
        {
            Essen = essen;
            Trinken = trinken;
            Gerausche = gerausche;
            Name = name;
            Alter = alter;
            Groeße = groese;
            Lebensdauer = lebensdauer;
            Gewicht = gewicht;
            Fell = fell;
        }



    }
}
