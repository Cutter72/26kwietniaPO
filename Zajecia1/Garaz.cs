using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1
{
    class Garaz
    {

        private Samochod[] samochody;

        private string adres;


        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        private int pojemnosc;

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set { pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        private int liczbaSamochodow = 0;

        public Garaz()
        {
            this.adres = "nieznany";
            this.pojemnosc = 0;
            this.samochody = null;

        }

        public Garaz(string adres, int pojemnosc)
        {
            
            this.adres = adres;
            this.pojemnosc = pojemnosc;
            this.samochody = new Samochod[pojemnosc];
        }


    }
}
