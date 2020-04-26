using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1
{
    class Samochod
    {
        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int iloscDrzwi;

        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        private int pojemnoscSilnika;

        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        private double srednieSpalanie;

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        private static int iloscSamochodow = 0;

        public Samochod() {
            this.model = "nieznany";
            this.marka = "nieznana";
            this.iloscDrzwi = 0;
            this.pojemnoscSilnika = 0;
            this.srednieSpalanie = 0.0;

            iloscSamochodow++;
        }

        public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
        {
            this.marka = marka_;
            this.model = model_;
            this.iloscDrzwi = iloscDrzwi_;
            this.pojemnoscSilnika = pojemnoscSilnika_;
            this.srednieSpalanie = srednieSpalanie_;

            iloscSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy) {
            return this.srednieSpalanie * dlugoscTrasy / 100;
        }


        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa) {
            double spalanie = ObliczSpalanie(dlugoscTrasy);
            return spalanie * cenaPaliwa;
        }


    }
}
