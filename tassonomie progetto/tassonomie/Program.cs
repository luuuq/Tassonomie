using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie
{
    class Program
    {
        static void Main(string[] args)
        {
            cavallo c = new cavallo();
            uomo u = new uomo();
            salmone s = new salmone();
            pinguino p = new pinguino();
            corvo cor = new corvo();
            cavallo cav = new cavallo();
            
            c.riepilogo();
            u.riepilogo();
            s.riepilogo();
            p.riepilogo();
            cor.riepilogo();
            cav.riepilogo();
            Console.ReadLine();
        }
    }
}
