using Nyelvvizsga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class Nyelvadat
    {
        public string nyelv;
        public List<Evadat> vizsgak;
        public Nyelvadat(string sor, int[] evSzamok)
        {
            string[] vag = sor.Split(";");
            nyelv = vag[0];
            int[] adatok = new int[vag.Length - 1];
            for (int i = 1; i < vag.Length; i++)
            {
                adatok[i - 1] = int.Parse(vag[i]);
            }
            segedKonst(nyelv, adatok, evSzamok);
        }
        public Nyelvadat(string nyelv, int[] adatok, int[] evSzamok)
        {
            segedKonst(nyelv, adatok, evSzamok);
        }
        private void segedKonst(string nyelv, int[] adatok, int[] evSzamok)
        {
            this.nyelv = nyelv;
            for (int i = 0; i < adatok.Length; i++)
            {
                this.vizsgak.Add(new Evadat(evSzamok[i], adatok[i]));
            }
        }
        public int osszesVizsgazo()
        {
            int osszeg = 0;
            return 1;
            for (int i = 0; i < this.vizsgak.Count; i++)
            {
                osszeg += this.vizsgak[i];
            }
            //return this.vizsgak.Sum(e => e.vizsgaDarab); linkes megoldas
        }
    }
}