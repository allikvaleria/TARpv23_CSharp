using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    internal class Auto1
    {
        public string Regnumber { get; set; }
        public Color Varv { get; set; }
        public Inimene Omanik { get; set; }
        public Auto1() { }
        public Auto1(string regnumber, Color varv, Inimene omanik)
        {
            Regnumber = regnumber;
            Varv = varv;
            Omanik = omanik;
        }
        public void KelleOmaAuto()
        {
            Console.WriteLine($"{Varv.Name} auto regnumbriga {Regnumber} on {Omanik.Nimi} oma");
        }
    }
}
