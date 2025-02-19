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

        public class1(int red, int green, int blue)
        {
            r = (byte)red;
            g = (byte)green;
            b = (byte)blue;
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
