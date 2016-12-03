using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class animale_terrestre:animale
    {
        public animale_terrestre(string nome, string tipo, string abitat, int zampe): base(nome, "animalee terrestre", "terra", zampe)
        {
        }
        public override string simuove()
        {
            return "cammina, corre";
        }
    }
}
