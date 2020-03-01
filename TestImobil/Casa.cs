using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImobil
{
   public class Casa:Imobil
    {
        public bool areGaraj;

        public string AfiseazaInformatiiImobil()
        {
            return "Adresa: " + base.adresa + "\nSuprafata: " + base.suprafata + "\nPret: " + base.pret + "\nAre Garaj: " + areGaraj;
        }


    }
}
