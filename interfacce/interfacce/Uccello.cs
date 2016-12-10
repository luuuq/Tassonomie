using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Uccello:Animale_terrestre, Animale_piumoso
    {
        
        public Uccello(string nome, string tipo, string specie, string abitat, int zampe)
            : base(nome, "animale terrestre", "uccello", "terra", zampe)
        { }

        public override string siMuove()
        {
            return "vola";
        }
        public void setManto()
        {
            manto = "piumoso";
        }
    }
}
