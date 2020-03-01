using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    public class Animal
    {
        public string tipAnimal;
        public string numeAnimal;
        public byte varstaAnimal;
        public string culoareAnimal;

        public string AfiseazaInformatiiGenerale()
        {
            return "Tip animal: " + tipAnimal + "\nNume: " + numeAnimal + "\nVarsta: " + varstaAnimal + "\nCuloare: " + culoareAnimal;
        }

    }
}
