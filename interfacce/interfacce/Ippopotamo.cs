using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    class Ippopotamo: Mammifero_fluviale, Quadrupede
    {
        public Ippopotamo()
            : base("ippopotamo", "mammifero fluciale", "Cavallo", "fiume, terra", 4)
        { }

        public void setZampe()
        {
            numeroZampe = 4;
        }
    }
}