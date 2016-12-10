using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            Uomo u = new Uomo();
            Cavallo c = new Cavallo();
            Ippopotamo i = new Ippopotamo();
            Corvo cv = new Corvo();
            Pinguino p = new Pinguino();
            Tonno t = new Tonno();
            Salmone s = new Salmone();

            u.riepilogo();
            Console.WriteLine("-----------------------------------------");
            c.riepilogo();
            Console.WriteLine("-----------------------------------------");
            i.riepilogo();
            Console.WriteLine("-----------------------------------------");
            cv.riepilogo();
            Console.WriteLine("-----------------------------------------");
            t.riepilogo();
            Console.WriteLine("-----------------------------------------");
            s.riepilogo();
            Console.ReadLine();
        }
    }
}
