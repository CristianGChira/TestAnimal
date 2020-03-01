using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Caine caine1 = new Caine();
            caine1.AfiseazaInformatiiCaine("caine", "Rex");
            Console.WriteLine();
            caine1.AfiseazaInformatiiCaine("caine", "Rex", 2);
            Console.WriteLine();
            caine1.AfiseazaInformatiiCaine("caine", "Rex", 2, "maro", "medie");


            Pisica pisica1 = new Pisica();
            pisica1.tipAnimal = "pisica";
            pisica1.numeAnimal = "Figaro";
            pisica1.varstaAnimal = 3;
            pisica1.culoareAnimal = "gri";
            pisica1.prindeSoareci = false;

            Console.WriteLine(  );
            Console.WriteLine(pisica1.AfiseazaInformatiiGenerale());

            Console.ReadKey();

        }
    }
}
