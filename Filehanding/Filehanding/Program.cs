using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_CreateFile
{
    class Program
    {
        static void Main(string[]args)
        {

            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");
            //fi.CopyTo("C:/010Projects/Tag_1_Wiederholung/Wiederholung tag 1nr2/Meine_datnr2323a.csv");
            //Console.WriteLine("File has been created and the Path is C:\\010Projects\\Tag_1_Wiederholung\\Wiederholung tag 1nr2\\csharpfile.txt");
            //FileInfo f1_neu = new FileInfo("C:/010Projects/Tag_1_Wiederholung/Wiederholung tag 1nr2/Meine_datnr2323a.csv");
            //f1_neu.Delete();
            //Console.WriteLine("Gebe mir den Namen wo di edatei verschieben werden soll");
            //string path = Console.ReadLine();
            //DirectoryInfo di = new DirectoryInfo(path);
            //while (di.Exists == false)
            //{
            //   Console.WriteLine("Dein Pfad gibt es nicht, gib mir einen neuen");
            //   path = Console.ReadLine();
            //   di = new DirectoryInfo(path);
            //}
            //Console.WriteLine("Wie soll die DAtai heißen");
            //string fileName = Console.ReadLine();
            //fi.CopyTo(path+"\\"+fileName);

            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");

            //if (fi.Exists)
            //{
            //Execute if avalible 
            //fi.CopyTo("C:/ 010Projects / Tag_1_Wiederholung / Wiederholung tag 1nr2 / Meine_datnr2323a.csv");
            //}

            string path = @"C:/010Projects/Tag_1_Wiederholung/Wiederholung tag 1nr2/Meine_data.csv";
            StreamReader sr = new StreamReader(path);
            List<string[]> eintraege = new List<string[]>();
            //Remove headline
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                eintraege.Add(sr.ReadLine().Split(';'));
            }

            StreamWriter sw = new StreamWriter(@"C:/010Projects/Tag_1_Wiederholung/Wiederholung tag 1nr2/JungeHüpfer.csv");


            for (int i = 0; i < eintraege.Count; i++)
            {

                if (Convert.ToInt32(eintraege[i][2]) < 20 && eintraege[i][0] == "m")
                {
                    Console.WriteLine(string.Join("\t", eintraege[i]));
                    sw.WriteLine(string.Join(";", eintraege[i]));
                }
            }
            sw.Close();
            sw.Dispose();

            Console.ReadKey();

            
        }
    }
}