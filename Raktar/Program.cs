using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{

    class Program
    {

        static List<Termek> termekek = new List<Termek>();

        static List<Megrendeles> megrendelesek = new List<Megrendeles>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                //sor[0] - kód, sor[1] - nev ... stb.
                string[] sor = raktar.ReadLine().Split(';');
                //Termek t = new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3]));      ennel lehet rovidebben

                //t.Kod = sor[0];                                                                   ez nem jo
                //t.Nev = sor[1];
                //t.Ar = Convert.ToInt32(sor[2]);
                //t.Db = Convert.ToInt32(sor[3]);

                termekek.Add(new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
            }
            raktar.Close();
        }

        static void BeolvasRendeles()
        {
            StreamReader rendeles = new StreamReader("rendeles.csv");

            while (!rendeles.EndOfStream)
            {
                string[] sor = rendeles.ReadLine().Split(';');

                //Megrendeles m = new Megrendeles(sor[1], sor[2], sor[3]);

                if (sor[0]=="M")
                {
                    megrendelesek.Add(new Megrendeles(sor[1], sor[2], sor[3]));
                }
            }
            rendeles.Close();
        }

        static void Main(string[] args)
        {
            //Termek t = new Termek("Póló", "Póló XXL", 1500, 10);   //peldanyositas

            BeolvasRaktar();
            BeolvasRendeles();

           

            foreach (var m in megrendelesek)
            {
                 Console.Write("{0}   \t{1}   \t{2}\n", m.Datum, m.Rendelesszam, m.Email);
            }

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }

            Console.ReadKey();
        }
    }
}
