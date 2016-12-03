using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    public abstract class animale
    {
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numZampe;

        
        public animale(string nome, string tipo, string abitat, int zampe)
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            habitat = abitat;
            numZampe = zampe;
        }
        public abstract string simuove();

        public void riepilogo()
        {
            Console.WriteLine(nomeAnimale);
            Console.WriteLine(tipoAnimale);
            Console.WriteLine(habitat);
            Console.WriteLine(numZampe);
        }
    }
}
