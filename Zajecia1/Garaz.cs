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
        private int pojemnosc;
        private int liczbaSamochodow = 0;


        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }


        public int Pojemnosc
        {
            get { return pojemnosc; }
            set { pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }


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

        public void WprowadzSamochod(Samochod s) {
            if (this.pojemnosc == this.liczbaSamochodow)
            {
                Console.WriteLine($"Garaż jest pełny!");
            }
            else
            {
                samochody[liczbaSamochodow] = s;
                liczbaSamochodow++;
            }
        }

        public Samochod WyprowadzSamochod() {
            if (liczbaSamochodow == 0)
            {
                Console.WriteLine($"Garaż jest pusty!");
                return null;
            }
            else
            {
                liczbaSamochodow--;
                Samochod s = samochody[liczbaSamochodow];
                samochody[liczbaSamochodow] = null;
                return s;
            }
        }

        public void WypiszInfo() {
            Console.WriteLine($"Informacje o garażu: adres {this.adres}, pojemnosc {this.pojemnosc}");
            Console.WriteLine($"Informacje o samochodach w tym garażu: ");

            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
            }
        }

    }
}
