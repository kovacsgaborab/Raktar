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

        List<Termek> termekek = new List<Termek>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                //sor[0] - kód, sor[1] - nev ... stb.
                string[] sor = raktar.ReadLine().Split(';');
            }
            raktar.Close();
        }

        static void Main(string[] args)
        {
            Termek t = new Termek("Póló", "Póló XXL", 1500, 10);   //peldanyositas

            BeolvasRaktar();

            Console.ReadKey();
        }
    }
}
