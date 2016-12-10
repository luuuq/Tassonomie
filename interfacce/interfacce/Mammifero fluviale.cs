using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Mammifero_fluviale:Animale_terrestre
    {
        public Mammifero_fluviale(string nome, string tipo, string specie, string abitat, int zampe)
            : base(nome, "mammifero fluviale", "mammifero", "fiume", zampe)
        { }
        public override string siMuove()
        {
            return "nuota";
        }
    }
}
