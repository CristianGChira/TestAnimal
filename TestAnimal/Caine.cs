using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    public class Caine:Animal
    {
        public string statura;

        public void AfiseazaInformatiiCaine(string tipAnimal, string numeAnimal)
        {
            Console.WriteLine("Tip animal: " + tipAnimal + "\nNume: " + numeAnimal);
        }

        public void AfiseazaInformatiiCaine(string tipAnimal, string numeAnimal, byte varstaAnimal)
        {
            Console.WriteLine("Tip animal: " + tipAnimal + "\nNume: " + numeAnimal + "\nVarsta: " + varstaAnimal);
        }

        public void AfiseazaInformatiiCaine(string tipAnimal, string numeAnimal, byte varstaAnimal, string culoareAnimal, string statura)
        {
            Console.WriteLine("Tip animal: " + tipAnimal + "\nNume: " + numeAnimal + "\nVarsta: " + varstaAnimal + "\nCuloare: " + culoareAnimal + "\nStatura: " + statura);
        }


    }
}
