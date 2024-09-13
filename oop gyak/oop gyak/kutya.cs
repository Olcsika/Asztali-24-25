using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyak
{
    internal class kutya
    {

        public string nev;

        public kutya(string nev)
            
        {
            this.nev = nev;
            Console.WriteLine("Kutya megszületett");
        }
        public void ugat()
        {
            Console.WriteLine("vauuuuu");
        }
        private float _suly;
        public float suly
        {
            get
            {
                return _suly;
            }
            set
            {
                _suly = Math.Abs(value) ;
            }
        }
        public override string ToString()
        {
            return "Kutya: "+ nev+ "Suly: "+_suly ;
        }
        static public string  ezMiEz()
        {
            return "ez egy kutya";
        }
        
    }
}
