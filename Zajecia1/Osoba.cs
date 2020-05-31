using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow;
        private string[] numeryPojazdow;

        public Osoba()
        {
            this.numeryPojazdow = new string[3];
        }

        public Osoba(string imie, string zanzwisko, string adresZamieszkania, int iloscSamochodow)
        {
            this.numeryPojazdow = new string[3];
            this.imie = imie;
            this.nazwisko = zanzwisko;
            this.adresZamieszkania = adresZamieszkania;
            this.iloscSamochodow = iloscSamochodow;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string AdresZamieszkania { get => adresZamieszkania; set => adresZamieszkania = value; }

        public void DodajSamochod(string numerRejestracyjny)
        {
            foreach (string nr in this.numeryPojazdow)
            {
                if (nr != null && nr.Equals(numerRejestracyjny))
                {
                    return;
                }
            }
            for (int i = 0 ; i < this.numeryPojazdow.Length; i++)
            {
                if (this.numeryPojazdow[i] == null)
                {
                    this.numeryPojazdow[i] = numerRejestracyjny;
                    this.iloscSamochodow++;
                    return;
                }
            }
        }
        public void UsunSamochod(string numerRejestracyjny)
        {
            for (int i = 0; i < this.numeryPojazdow.Length; i++)
            {
                if (this.numeryPojazdow[i] != null && this.numeryPojazdow[i].Equals(numerRejestracyjny))
                {
                    this.numeryPojazdow[i] = null;
                    this.iloscSamochodow--;
                    return;
                }
            }
        }
        public void WypiszInfo()
        {
            Console.WriteLine($"\nImie: {this.imie}");
            Console.WriteLine($"Nazwisko: {this.nazwisko}");
            Console.WriteLine($"Adres zamieszkania: {this.adresZamieszkania}");
            Console.WriteLine($"Posiada {this.iloscSamochodow} samochód/samochodów");
            foreach (string nr in numeryPojazdow)
            {
                if (nr != null)
                {
                    Console.WriteLine($"Numer pojazdu: {nr}");
                }
            }
        }
    }
}
