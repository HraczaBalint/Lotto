using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Adatok
    {
        private int Ev;
        private int Het;
        private int Datum;
        private int OtosTalalat;
        private int OtosNyeremeny;
        private int NegyesTalalat;
        private int NegyesNyeremeny;
        private int HarmasTalalat;
        private int HarmasNyeremeny;
        private int KEttesTalalat;
        private int KettesNYeremeny;
        private int ElsoSzam;
        private int MasodikSzam;
        private int HarmadikSzam;
        private int NegyedikSzam;
        private int OtodikSzam;

        public Adatok(int ev, int het, int datum, int otosTalalat, int otosNyeremeny, int negyesTalalat, int negyesNyeremeny, int harmasTalalat, int harmasNyeremeny, int kEttesTalalat, int kettesNYeremeny, int elsoSzam, int masodikSzam, int harmadikSzam, int negyedikSzam, int otodikSzam)
        {
            Ev = ev;
            Het = het;
            Datum = datum;
            OtosTalalat = otosTalalat;
            OtosNyeremeny = otosNyeremeny;
            NegyesTalalat = negyesTalalat;
            NegyesNyeremeny = negyesNyeremeny;
            HarmasTalalat = harmasTalalat;
            HarmasNyeremeny = harmasNyeremeny;
            KEttesTalalat = kEttesTalalat;
            KettesNYeremeny = kettesNYeremeny;
            ElsoSzam = elsoSzam;
            MasodikSzam = masodikSzam;
            HarmadikSzam = harmadikSzam;
            NegyedikSzam = negyedikSzam;
            OtodikSzam = otodikSzam;
        }
    }
}
