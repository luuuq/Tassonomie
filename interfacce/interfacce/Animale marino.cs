using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Animale_marino:Animale
    {
        public Animale_marino(string nome, string tipo, string specie, string abitat, int zampe)
            : base(nome, "animale marino", specie, "mare", zampe)
        { }

        public override string siMuove()
        {
            return "nuota";
        }
    }
}
