using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    class Cavallo: Mammifero_terrestre, Quadrupede, Animale_peloso
    {
        public Cavallo()
            : base("cavallo", "mammifero terrestre", "cavallo", "terra", 4)
        { }

        public override string siMuove()
        {
            return "cammina, corre";
        }

        public void setZampe()
        {
            numeroZampe = 4;
        }

        public void setManto()
        {
            manto = "peloso";
        }
    }
}
