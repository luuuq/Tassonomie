using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Mammifero_marino:Animale_marino
    {
        public Mammifero_marino(string nome, string tipo, string specie, string abitat, int zampe)
            : base(nome, "mammifero marino", "mammifero", "mare", zampe)
        { }
        public override string siMuove()
        {
            return "nuota";
        }
    }
}
