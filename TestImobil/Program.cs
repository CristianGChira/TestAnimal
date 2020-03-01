using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartament apartament = new Apartament();
            apartament.AfiseazaInformatiiApartament("Bucuresti", 80);
            Console.WriteLine( );
            apartament.AfiseazaInformatiiApartament("Bucuresti", 80, 90000);
            Console.WriteLine();
            apartament.AfiseazaInformatiiApartament("Bucuresti", 80, 90000, 1);

            Casa casa = new Casa();
            casa.adresa = "Constanta";
            casa.suprafata = 100;
            casa.pret = 120000;
            casa.areGaraj = true;

            Console.WriteLine();
            Console.WriteLine(casa.AfiseazaInformatiiImobil());

            Console.ReadKey();

        }
    }
}
