using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class uccello:animale_terrestre
    {
        public uccello(string nome, string tipo, string abitat, int zampe): base(nome, "terrestre", "terra", zampe)
        {
        }
    }
}
