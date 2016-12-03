using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class uomo:bipede
    {
        public uomo(): base("uomo", "bipede", "terra", 2)
        { 
        }
        public override string simuove()
        {
            return "cammina, corre";
        }
    }
}
