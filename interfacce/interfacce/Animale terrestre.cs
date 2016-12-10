using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Animale_terrestre: Animale
    {
        public Animale_terrestre(string nome, string tipo, string specie, string abitat, int zampe)
            : base(nome, "animale terrestre", specie , "terra", zampe)
        { }
        public override string siMuove()
        {
            return "cammina, corre";
        }
    }
}
