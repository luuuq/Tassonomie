using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Pesce:Animale_marino, Animale_squamoso
    {
        public Pesce(string nome, string tipo, string specie, string abitat, int zampe)
            : base("pesce", "animale marino", "pesce", "mare", 0)
        { }

        public override string siMuove()
        {
            return "nuota";
        }

        public void Setmanto()
        {
            manto = "squamoso";
        }
    }
}
