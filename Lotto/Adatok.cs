using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Adatok
    {
        private int ev;
        private int het;
        private string datum;
        private int otosTalalat;
        private string otosNyeremeny;
        private int negyesTalalat;
        private string negyesNyeremeny;
        private int harmasTalalat;
        private string harmasNyeremeny;
        private int kettesTalalat;
        private string kettesNyeremeny;
        private int elsoSzam;
        private int masodikSzam;
        private int harmadikSzam;
        private int negyedikSzam;
        private int otodikSzam;

        public Adatok(int ev, int het, string datum, int otosTalalat, string otosNyeremeny, int negyesTalalat, string negyesNyeremeny, int harmasTalalat, string harmasNyeremeny, int kettesTalalat, string kettesNyeremeny, int elsoSzam, int masodikSzam, int harmadikSzam, int negyedikSzam, int otodikSzam)
        {
            this.ev = ev;
            this.het = het;
            this.datum = datum;
            this.otosTalalat = otosTalalat;
            this.otosNyeremeny = otosNyeremeny;
            this.negyesTalalat = negyesTalalat;
            this.negyesNyeremeny = negyesNyeremeny;
            this.harmasTalalat = harmasTalalat;
            this.harmasNyeremeny = harmasNyeremeny;
            this.kettesTalalat = kettesTalalat;
            this.kettesNyeremeny = kettesNyeremeny;
            this.elsoSzam = elsoSzam;
            this.masodikSzam = masodikSzam;
            this.harmadikSzam = harmadikSzam;
            this.negyedikSzam = negyedikSzam;
            this.otodikSzam = otodikSzam;
        }

        public int Ev { get => ev; set => ev = value; }
        public int Het { get => het; set => het = value; }
        public string Datum { get => datum; set => datum = value; }
        public int OtosTalalat { get => otosTalalat; set => otosTalalat = value; }
        public string OtosNyeremeny { get => otosNyeremeny; set => otosNyeremeny = value; }
        public int NegyesTalalat { get => negyesTalalat; set => negyesTalalat = value; }
        public string NegyesNyeremeny { get => negyesNyeremeny; set => negyesNyeremeny = value; }
        public int HarmasTalalat { get => harmasTalalat; set => harmasTalalat = value; }
        public string HarmasNyeremeny { get => harmasNyeremeny; set => harmasNyeremeny = value; }
        public int KettesTalalat { get => kettesTalalat; set => kettesTalalat = value; }
        public string KettesNYeremeny { get => kettesNyeremeny; set => kettesNyeremeny = value; }
        public int ElsoSzam { get => elsoSzam; set => elsoSzam = value; }
        public int MasodikSzam { get => masodikSzam; set => masodikSzam = value; }
        public int HarmadikSzam { get => harmadikSzam; set => harmadikSzam = value; }
        public int NegyedikSzam { get => negyedikSzam; set => negyedikSzam = value; }
        public int OtodikSzam { get => otodikSzam; set => otodikSzam = value; }
    }
}
