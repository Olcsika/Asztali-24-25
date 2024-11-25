using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace vonatos_oop
{
    internal class vonat
    {
        public int kocsi;
        public vonat(int kocsi) 
        {
            this.kocsi = kocsi;
        }
        
        public static vonat operator +(vonat v1, vonat v2)
        {
            return new vonat(v1.kocsi + v2.kocsi);
        }
        public static vonat operator -(vonat v1, vonat v2)
        {
            return new vonat(v1.kocsi - v2.kocsi);
        }
        public override string ToString() 
        {
            return kocsi + " darab";
        }
    }
}
