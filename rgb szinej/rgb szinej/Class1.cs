using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb_szinej
{
    internal class class1
    {
        public byte r;
        public byte g;
        public byte b;

        public Szin(int red, int green, int blue)
        {
            this.r = (byte)red;
            this.g = (byte)green;
            this.b = (byte)blue;

        }

        public override string ToString()
        {
            return $"RGB({r}, {g}, {b})";
        }

        public bool vilagos()
        {


            return osszeg() > 600;
        }

        public int osszeg()
        {
            return r + g + b;
        }
    }
  
}
