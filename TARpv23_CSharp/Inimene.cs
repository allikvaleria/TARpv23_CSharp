using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public enum Sugu
    {
        Mees,
        Naine
    }
    public enum Aktiivsus
    {
        Istuv, 
        Vähene, 
        Mõõdukas, 
        Kõrge, 
        Väga_kõrge
    }
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Sugu Sugu { get; set; }
        public Aktiivsus Aktiivsus { get; set; }
        public int Pikkus { get; set; }
        public double Kaal { get; set; }

        public Inimene() { }
        public Inimene(string nimi, int vanus, Sugu sugu = Sugu.Mees, Aktiivsus aktiivsus = default)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Aktiivsus = aktiivsus;
        }
        public double kaloriteArvutamine( Aktiivsus aktiivsus)
        {
            double SBI = 0;
            if (Sugu == 0)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else
            {
                SBI = 655 + (9.6 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            switch (aktiivsus)
            {
                case Aktiivsus.Istuv:
                    SBI=SBI * 1.2;
                    break;

                case Aktiivsus.Vähene:
                    SBI = SBI * 1.375;
                    break;

                case Aktiivsus.Mõõdukas:
                    SBI = SBI * 1.55;
                    break;

                case Aktiivsus.Kõrge:
                    SBI = SBI * 1.725;
                    break;

                case Aktiivsus.Väga_kõrge:
                    SBI = SBI * 1.9;
                    break;
                default:
                    break;

            } 
            return Math.Round(SBI);
        }
            
    }
}
