using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    class Mammifero_terrestre:Animale_terrestre
    {
        public Mammifero_terrestre(string nome, string tipo, string specie, string abitat, int zampe)
            : base(nome, "mammifero terrestre", "mammifero", "terra", zampe)
        { }
        public override string siMuove()
        {
            return "cammina, corre";
        }
    }
}
