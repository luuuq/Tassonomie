using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Uccello_marino:Animale_marino
    {
        public Uccello_marino(string nome, string tipo, string specie, string abitat, int zampe)
            : base(nome, "uccello marino", "uccello", "mare", zampe)
        { }
        public override string siMuove()
        {
            return "nuota";
        }
    }
}
