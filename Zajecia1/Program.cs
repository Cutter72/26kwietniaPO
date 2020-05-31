using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1
{
    class Program
    {
        static void Main(string[] args)
        {

            //#region testyDlaSamochod
            //Samochod s1 = new Samochod();
            //s1.WypiszInfo();
            //s1.Marka = "Fiat";
            //s1.Model = "126p";
            //s1.IloscDrzwi = 2;
            //s1.PojemnoscSilnika = 650;
            //s1.SrednieSpalanie = 6.0;
            //s1.WypiszInfo();
            //Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "ABC123");
            //s2.WypiszInfo();
            //double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            //Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
            //Samochod.WypiszIloscSamochodow();
            //Console.ReadKey();
            //#endregion

            //#region testyDlaGaraz
            //Console.WriteLine("\nTest Garażu:");
            //Samochod sam1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "ABC123");
            //Samochod sam2 = new Samochod("Syrena", "105", 2, 800, 7.6, "XYZ789");
            //Garaz g1 = new Garaz();
            //g1.Adres = "ul. Garażowa 1";
            //g1.Pojemnosc = 1;
            //Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            //g1.WprowadzSamochod(sam1);
            //g1.WypiszInfo();
            //g1.WprowadzSamochod(sam2);
            //g2.WprowadzSamochod(sam2);
            //g2.WprowadzSamochod(sam1);
            //g2.WypiszInfo();
            //g2.WyprowadzSamochod();
            //g2.WypiszInfo();
            //g2.WyprowadzSamochod();
            //g2.WyprowadzSamochod();
            //Console.ReadKey();
            //#endregion


            #region testyDlaOsoba
            Console.WriteLine("\nTest Osoby:");
            Samochod sam1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "ABC123");
            Samochod sam2 = new Samochod("Syrena", "105", 2, 800, 7.6, "XYZ789");
            Osoba os1 = new Osoba("Dorota", "Rabczewska", "al. Gwiazd", 0);
            os1.WypiszInfo();
            os1.DodajSamochod(sam1.NumerRejestracyjny);
            os1.WypiszInfo();
            os1.DodajSamochod(sam1.NumerRejestracyjny);
            os1.DodajSamochod(sam2.NumerRejestracyjny);
            os1.DodajSamochod(sam2.NumerRejestracyjny);
            os1.WypiszInfo();
            Console.ReadKey(); 
            #endregion


        }
    }
}
