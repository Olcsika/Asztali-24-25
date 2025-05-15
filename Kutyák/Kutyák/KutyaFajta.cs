using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    internal class KutyaFajta
    {
        public int id;
        public string nev;
        public string eredetiNev;

        public KutyaFajta(int id,string nev,string eredetinev)     
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetinev;
        }
    }
}
