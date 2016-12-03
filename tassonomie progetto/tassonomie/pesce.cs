using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class pesce: animale_marino
    {
        public pesce(string nome, string tipo, string abitat, int zampe): base("pesce", "animale marino", "mare", zampe)
        { 
        }
    }
}
