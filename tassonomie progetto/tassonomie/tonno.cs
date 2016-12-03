using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class tonno: animale_marino
    {
        public tonno(): base("tonno", "animale marino", "mare", 0)
        { 
        }
        public override string simuove()
        {
            return "nuota";
        }
    }
}
