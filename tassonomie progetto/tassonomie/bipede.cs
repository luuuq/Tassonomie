using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class bipede: animale_terrestre
    {
        public bipede(string nome, string tipo, string abitat, int zampe): base( nome, "bipede", "terra", 2)
        {
        }
        public override string simuove()
        {
            return "cammina, corre";
        }
    }
}
