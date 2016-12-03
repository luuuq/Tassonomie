using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class pinguino: uccello
    {
        public pinguino(): base("pinguino", "animale terestre/marino", "terra/mare", 2)
        {
        }
        public override string simuove()
        {
            return "cammina, nuota";
        }
    }
}
