using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class animale_aquatico:animale
    {
        public animale_aquatico(string nome, string tipo, string abitat, int zampe): base(nome, "animale aquatico", "acqua", zampe)
        { 
        }
        public override string simuove()
        {
            return "nuoto";
        }
    }
}
