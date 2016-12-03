using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class quadrupede: animale_terrestre
    {
        public quadrupede(string nome, string tipo, string abbitat, int zampe): base(nome, "terrestre", "terra", 4)
        {
        }
    }
}
