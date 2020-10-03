using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Feladat feladat = new Feladat(new List<Adatok>(), new List<int>());
            Console.WriteLine(feladat.Beolvasas());

            Console.ReadKey();
        }
    }
}
