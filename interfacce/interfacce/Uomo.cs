using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    class Uomo: Mammifero_terrestre, Animale_peloso, Bipede
    {
        public Uomo()
            : base("uomo", "mammifero terrestre", "umano", "terra", 2)
        { }

        public override string siMuove()
        {
            return "corre, cammina";
        }

        public void SetZampe()
        {
            numeroZampe = 2;
        }
        public void setManto()
        {
            manto = "pesolo";
        }
    }
}
