using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class corvo:animale_terrestre
    {
        public corvo(): base("corvo", "animale terrestre", "terra", 2)
        { 
        }
        public override string simuove()
        {
            return "vola, cammina";
        }
    }
}
