using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class animale_marino: animale
    {
        public animale_marino(string nome, string tipo, string abitat, int zampe): base(nome, "animale marino", "mare", zampe)
        { 
        }
        public override string simuove()
        {
            return "nuota";
        }
    }
}
