using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class salmone: animale_fluvaiale
    {
        public salmone(): base("salmone", "animale fluviale", "fiume", 0)
        { 
        }
        public override string simuove()
        {
            return "nuota";
        }
    } 
}
