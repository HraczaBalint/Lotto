using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lotto
{
    class Feladat
    {
        private List<Adatok> AdatokListaja = new List<Adatok>();

        public Feladat(List<Adatok> adatokListaja)
        {
            AdatokListaja = adatokListaja;
        }

        public void Beolvasas()
        {
            StreamReader sr = new StreamReader("otos.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] temp = sor.Split(';');
                Adatok adatok = new Adatok(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]), Convert.ToInt32(temp[4]), Convert.ToInt32(temp[5]), Convert.ToInt32(temp[6]), Convert.ToInt32(temp[7]), Convert.ToInt32(temp[8]), Convert.ToInt32(temp[9]), Convert.ToInt32(temp[10]), Convert.ToInt32(temp[11]), Convert.ToInt32(temp[12]), Convert.ToInt32(temp[13]), Convert.ToInt32(temp[14]), Convert.ToInt32(temp[15]));
                AdatokListaja.Add(adatok);
            }

        }

    }
}
