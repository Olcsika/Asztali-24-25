using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class Evadat
    {
        public int ev;
        public int vizsgaDarab;
        public Evadat(int ev, int db)
        {
            this.ev = ev;
            this.vizsgaDarab = db;
        }
        public static int operator + (Evadat a, Evadat b)
        {
            return a.vizsgaDarab + b.vizsgaDarab;
        }
        public static int operator + (Evadat a,int b)
        {
            return a.vizsgaDarab + b;
        }
        public static int operator+(int a,Evadat b)
        {
            return a+b.vizsgaDarab;
        }
    }
}