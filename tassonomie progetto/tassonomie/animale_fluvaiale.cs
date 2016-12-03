using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class animale_fluvaiale: animale_aquatico
    {
        public animale_fluvaiale(string nome, string tipo, string abitat, int zampe): base(nome, "animale fluviale", "fiume", zampe)
        { 
        }

        public override string simuove()
        {
            return "nuota";
        }
    }
}
