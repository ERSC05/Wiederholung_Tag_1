using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aquarium print
            string[,] aquarium = new string[10,10];
            for(int j = 0; j < 10; j++)
            {
                for(int i = 0; i<10; i++)
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

            List<Crap>Crap1 = new List<Crap>(); Crap1.Add(new Crap(3, "Erster Crap", 4));
            List<Shark>shark1 = new List<Shark>(); shark1.Add(new Shark(4, "Erster Shark", 5));
            List<Schwertfisch>schwertfisch1 = new List<Schwertfisch>(); schwertfisch1.Add(new Schwertfisch(6, "Erster Schwertfisch", 5));
            List<Kugelfisch> Kugelfisch1 = new List<Kugelfisch>(); Kugelfisch1.Add(new Kugelfisch(4, "Erster Kugelfisch", 5));
            Console.ReadLine();
            foreach (var crap in Crap1)
            {
                Console.WriteLine(crap.ToString());
            }


            Console.ReadLine();







                //Console.WriteLine("Gib mir eine Zahl");
                //string zahl1 = Console.ReadLine();
                //Console.WriteLine("Gib mir eine ander Zahl");
                //string zahl2 = Console.ReadLine();
                //Console.ReadLine();



                //int Ergebnis = Convert.ToInt32(Umwandler1(zahl1, zahl2));
                //Console.WriteLine($"{zahl1} + {zahl2} = {Ergebnis}");
                //            Console.WriteLine($"{zahl1} + {zahl2} = {Ergebnis}");
                //            Console.ReadLine();


                /*            double Ergebnis = 0;
                            Console.WriteLine("Gebe die erste zahl ein");
                            double Zahl1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Gebe die zweite Zahl ein");
                            double Zahl2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Gebe den operator ein");
                            string Operator= Console.ReadLine();

                            switch (Operator)
                            {
                                case "+":
                                    Ergebnis = Add(Zahl1, Zahl2);
                                    break;
                                case "-":
                                    Ergebnis = sub(Zahl1, Zahl2);
                                    break ;
                                case "*":
                                    Ergebnis = multi(Zahl1, Zahl2);
                                    break;
                                case "/":
                                    Ergebnis = divide(Zahl1, Zahl2);
                                    break;
                                case "&":
                                    Ergebnis = modu(Zahl1, Zahl2);
                                    break;
                                default:
                                    Console.WriteLine("Falscher operrator");
                                    break;

                            }

                            Console.WriteLine($"{Zahl1} {Operator} {Zahl2} = {Ergebnis}");

                */
                /*            List<Car> cars = new List<Car>();
                            cars.Add(new Car(5, " 1990 ", " BMW ", "Audi R8 ", " blue ", 7, false));
                            int a = 1;
                            int b = 0;
                            int GeschwindigkeitImput = 0;
                            while (a == a)
                            {
                                foreach (Car car in cars)
                                {


                                //car.Starten();
                                //car.Beschleunigen();

                                    switch (b)
                                    {
                                        case 1:
                                            car.Starten();
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;

                                        case 2:
                                            car.Beschleunigen();
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        case 3:
                                            car.Bremsen();
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        case 4:
                                            a = 2;
                                            break;
                                        default:
                                            Console.WriteLine("Gib mir einen Imput");
                                            Console.WriteLine("1  =  Starten");
                                            Console.WriteLine("2  =  Beschleunigen");
                                            Console.WriteLine("3  =  Bremsen");
                                            Console.WriteLine("4  =  Aufhören");
                                            b = Convert.ToInt32(Console.ReadLine());
                                            break;

                                    }
                                }
                            }






                */
                Console.ReadLine();

        }
/*        static double modu(double z1, double z2)
        {
            double Ergebnis = z1 % z2;
            return Ergebnis;
        }
        static double sub(double z1, double z2)
        {
            double Ergebnis = z1 - z2;
            return Ergebnis;
        }
        static double multi(double z1, double z2)
        {
            double Ergebnis = z1 * z2;
            return Ergebnis;
        }

        static double divide(double z1, double z2)
        {
            double Ergebnis = z1 / z2;
            return Ergebnis;
        }

        //static double Add(double z1, double z2)
        //{
        //    double Ergebnis = z1 + z2;

        //    return Ergebnis;
        //}

        static List<string> CreateGiveMeTrainiesWithM(List<string> allTrainiees)
        {
            List<string> TrainiesWithm = new List<string>();
            string n = "n";
            n = Console.ReadLine();
            
            
            if (TrainiesWithm.Count <=allTrainiees.Count) 
            {
                TrainiesWithm.Add(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Der name beginnt nicht mit einem n");
            }
            return TrainiesWithm;
        }
*/    }
    
}
