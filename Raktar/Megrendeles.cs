using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class Megrendeles
    {
        private string datum;

        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        private string rendelesszam;

        public string Rendelesszam
        {
            get { return rendelesszam; }
            set { rendelesszam = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int osszeg;

        public int Osszeg
        {
            get { return osszeg; }
            set { osszeg = value; }
        }

        public void Szamolas(List<Termek> termekek)
        {
            //kód alapján megkeresni a terméket --> ár
            //szum += ár * db (annyiszor, ahány termék van)

            int szum = 0;
            for (int i = 0; i < tetelek.Count; i++)
            {
                int ar = Ara(tetelek[i].Kod, termekek);
                szum += ar * tetelek[i].Db;

                this.osszeg = szum;
            }
        }

        private int Ara(string kod, List<Termek> termekek)
        {
            int i = 0;
            while (termekek[i].Kod != kod)
            {
                i++;
            }

            return termekek[i].Ar;
        }

        private List<Tetel> tetelek;

        public void Tetelhozzaad(string kod, int db)
        {
            tetelek.Add(new Tetel(kod, db));
        }

        public Megrendeles(string datum, string rendelesszam, string email)
        {
            this.datum = datum;
            this.rendelesszam = rendelesszam;
            this.email = email;
            tetelek = new List<Tetel>();
        }
    }
}
