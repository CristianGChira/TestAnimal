using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    class Pisica:Animal
    {
        public bool prindeSoareci;

        public string AfiseazaInformatiiGenerale()
        {
            return "Tip animal: " + base.tipAnimal + "\nNume: " + base.numeAnimal + "\nVarsta: " + base.varstaAnimal + "\nCuloare: " + base.culoareAnimal + "\nPrinde soareci: " + prindeSoareci;
        }

    }
}
