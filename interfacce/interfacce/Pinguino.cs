using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    class Pinguino: Uccello_marino, Animale_piumoso, Bipede
    {
        public Pinguino()
            : base("pinguino", "uccello marino", "pinguino", "mare", 2)
        { }

        public void setManto()
        {
            manto = "piumoso";
        }

        public void SetZampe()
        {
            numeroZampe = 2;
        }
    }
}
