using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImobil
{
    public class Apartament:Imobil
    {

        public byte etaj;

        public void AfiseazaInformatiiApartament(string adresa, int suprafata)
        {
            Console.WriteLine("Adresa: " + adresa + "\nSuprafata: " + suprafata);
        }
        public void AfiseazaInformatiiApartament(string adresa, int suprafata, double pret)
        {
            Console.WriteLine("Adresa: " + adresa + "\nSuprafata: " + suprafata + "\nPret: " + pret);
        }
        public void AfiseazaInformatiiApartament(string adresa, int suprafata, double pret, byte etaj)
        {
            Console.WriteLine("Adresa: " + adresa + "\nSuprafata: " + suprafata + "\nPret: " + pret + "\nEtaj: " + etaj);
        }

    }
}
