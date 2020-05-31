using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1
{
    class Samochod
    {
        private static int liczbaSamochodow = 0;

        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private string numerRejestracyjny;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }


        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }


        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        public string NumerRejestracyjny { get => numerRejestracyjny; set => numerRejestracyjny = value; }

        public Samochod() {
            this.model = "nieznany";
            this.marka = "nieznana";
            this.iloscDrzwi = 0;
            this.pojemnoscSilnika = 0;
            this.srednieSpalanie = 0.0;
            this.numerRejestracyjny = "nieznany";

            liczbaSamochodow++;
        }

        public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_, string numerRejestracyjny)
        {
            this.marka = marka_;
            this.model = model_;
            this.iloscDrzwi = iloscDrzwi_;
            this.pojemnoscSilnika = pojemnoscSilnika_;
            this.srednieSpalanie = srednieSpalanie_;
            this.NumerRejestracyjny = numerRejestracyjny;

            liczbaSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy) {
            return this.srednieSpalanie * dlugoscTrasy / 100;
        }


        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa) {
            double spalanie = ObliczSpalanie(dlugoscTrasy);
            return spalanie * cenaPaliwa;
        }

        public void WypiszInfo() {
            Console.WriteLine($"Marka: {this.marka}");
            Console.WriteLine($"Model: {this.model}");
            Console.WriteLine($"Ilość drzwi: {this.iloscDrzwi}");
            Console.WriteLine($"Pojemnosc silnika: {this.pojemnoscSilnika}");
            Console.WriteLine($"Średnie spalanie: {this.srednieSpalanie}");
        }

        public static void WypiszIloscSamochodow() {
            Console.WriteLine($"Utworzono już {liczbaSamochodow} samochodów.");
        }
    }
}
