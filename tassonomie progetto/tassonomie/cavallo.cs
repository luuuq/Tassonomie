using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class cavallo: animale_terrestre
    {
        public cavallo(): base("cavallo", "animale terrestre", "terra", 4)
        {
        }
        public override string simuove()
        {
            return "cammina, corre";
        }
    }
}
