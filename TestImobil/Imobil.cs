using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImobil
{
   public class Imobil
    {
        public string adresa;
        public int suprafata;
        public double pret;
        

        public string AfiseazaInformatiiImobil()
        {
            return "Adresa: " + adresa + "\nSuprafata: " + suprafata + "\nPret: " + pret;
        }
    }
}
