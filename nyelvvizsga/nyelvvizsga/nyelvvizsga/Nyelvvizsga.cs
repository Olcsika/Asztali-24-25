using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyelvvizsga
{
    internal class Nyelvvizsga
    {
        public string nyelv;
        public List<Evadat> vizsgak=new List<Evadat>();

        public Nyelvvizsga(string sor, int[] evszamok)
        {
            string[] vag = sor.Split(";");
            nyelv = vag[0];
            
        }
        public Nyelvvizsga(string nyelv, int[]adatok, int[] evszamok) 
        {
            this.nyelv = nyelv;
            for (int i = 0; i < adatok.Length; i++) 
            {
                this.vizsgak.Add(new Evadat(evszamok[i],adatok[i]));
            }
        }

       
    }
}
