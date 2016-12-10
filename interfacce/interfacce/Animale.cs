using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    abstract class Animale
    {
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string specieAnimale;
        protected string habitat;
        protected int numeroZampe;
        protected string manto;

        public Animale(string nome, string tipo, string specie, string abitat, int zampe)
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            specieAnimale = specie;
            habitat = abitat;
            numeroZampe = zampe;
        }

        public abstract string siMuove();

        public void riepilogo()
        {
            Console.WriteLine(nomeAnimale);
            Console.WriteLine(tipoAnimale);
            Console.WriteLine(specieAnimale);
            Console.WriteLine(habitat);
            Console.WriteLine(numeroZampe);
            Console.WriteLine(manto);
        }

    }
}
