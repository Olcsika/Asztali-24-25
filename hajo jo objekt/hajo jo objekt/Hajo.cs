﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajo_jo_objekt
{
    internal class Hajo:IHajo
    {
        public int hossz {  get; set; }

        public string nev { get; set; }
        public int merules { get; set; }
        public int vizkiszoritas {  get; set; }
        //vizkiszoritas
        //nev
        //merules
        public Hajo(string nev)
        {
            this.nev = nev;
        }
        public Hajo(string nev, int hossz)
        {
            this.nev = nev;
            this.hossz = hossz; 
        }


        public void megfordul()
        {

        }
        public void halad()
        {

        }
        public void hangjelzes()
        {

        }
        public void sullyed()
        {

        }
    }
}
