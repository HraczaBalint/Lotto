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
        private List<int> TippeltSzamok = new List<int>();
        private int EltalaltSzamok = 0;
        private int KettesTalálatokSzama = 0;
        private int HarmasTalalatokSzama = 0;
        private int NegyestalalatokSzama = 0;
        private int OtosTalalatokSzama = 0;

        private int tipp;

        public Feladat(List<Adatok> adatokListaja, List<int> tippeltSzamok)
        {
            AdatokListaja = adatokListaja;
            TippeltSzamok = tippeltSzamok;
        }

        public string Beolvasas()
        {
            StreamReader sr = new StreamReader("otos.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] temp = sor.Split(';');
                Adatok adatok = new Adatok(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]), temp[2], Convert.ToInt32(temp[3]), temp[4], Convert.ToInt32(temp[5]), temp[6], Convert.ToInt32(temp[7]), temp[8], Convert.ToInt32(temp[9]), temp[10], Convert.ToInt32(temp[11]), Convert.ToInt32(temp[12]), Convert.ToInt32(temp[13]), Convert.ToInt32(temp[14]), Convert.ToInt32(temp[15]));
                AdatokListaja.Add(adatok);
            }
            sr.Close();

            Bekeres();

            return "";
        }

        public List<int> Bekeres()
        {
            Console.WriteLine("Adjon meg 5 darab különböző számot 1 és 90 között!");

            for (int i = 0; i < 5; i++)
            {
                tipp = Convert.ToInt32(Console.ReadLine());
                while (TippeltSzamok.Contains(tipp) || tipp > 90 || tipp < 0)
                {
                    Console.WriteLine("Adjon meg egy új számot!");
                    tipp = Convert.ToInt32(Console.ReadLine());
                }
                TippeltSzamok.Add(tipp);
            }

            Kiertekeles();

            return null;
        }

        public string Kiertekeles()
        {
            for (int i = 0; i < AdatokListaja.Count; i++)
            {
                if (TippeltSzamok.Contains(AdatokListaja[i].ElsoSzam))
                {
                    EltalaltSzamok++;
                }
                if (TippeltSzamok.Contains(AdatokListaja[i].MasodikSzam))
                {
                    EltalaltSzamok++;
                }
                if (TippeltSzamok.Contains(AdatokListaja[i].HarmadikSzam))
                {
                    EltalaltSzamok++;
                }
                if (TippeltSzamok.Contains(AdatokListaja[i].NegyedikSzam))
                {
                    EltalaltSzamok++;
                }
                if (TippeltSzamok.Contains(AdatokListaja[i].OtodikSzam))
                {
                    EltalaltSzamok++;
                }


                if (EltalaltSzamok == 2)
                {
                    KettesTalálatokSzama++;
                }
                if (EltalaltSzamok == 3)
                {
                    HarmasTalalatokSzama++;
                }
                if (EltalaltSzamok == 4)
                {
                    NegyestalalatokSzama++;
                }
                if (EltalaltSzamok == 5)
                {
                    OtosTalalatokSzama++;
                }

                EltalaltSzamok = 0;
            }

            Console.WriteLine($"Kettes találatok száma: {KettesTalálatokSzama} \nHármas találatok száma: {HarmasTalalatokSzama} \nNégyes találatok száma: {NegyestalalatokSzama} \nÖtös találatok száma: {OtosTalalatokSzama}");

            return null;
        } 
    }
}
