using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public class Funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }

        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        // Loo Arvuta() funktsiooni, mis sõldub 3 parameetrist: teha, arv1, arv2. Kastuta if konstruktsioon. Tulemus kuva ekraanile.
        public static int Korrutamine(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        public static int Lahutamine(int arv1, int arv2)
        {
            return arv1 - arv2;
        }
        public static int Jagamine(int arv1, int arv2)
        {
            return arv1 / arv2;
        }
    }
}
