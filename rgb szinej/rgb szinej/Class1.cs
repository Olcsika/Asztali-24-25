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

<<<<<<< HEAD
        public class1(int red, int green, int blue)
=======
        public Szin(int red, int green, int blue)
>>>>>>> e3f33eaa0bd2325d75c7854ade2611a3b9de64eb
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
        public override string ToString()
        {
            return $"RGB({r},{g},{b})";
        }

        public int osszge()
        {
            return r + b + g;
        }

        public bool vilagos()
        {
            return r + b + g > 600;
        }
    }
  
}
