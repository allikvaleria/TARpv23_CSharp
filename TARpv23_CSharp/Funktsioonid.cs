using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace TARpv23_CSharp
//{
//    public class Funktsioonid
//    {
//        public static void Tere(string nimi)
//        {
//            Console.WriteLine("Tere kallis {0}", nimi);
//        }

//        public static int Liitmine(int arv1, int arv2)
//        {
//            return arv1 + arv2;
//        }
//        // Loo Arvuta() funktsiooni, mis sõldub 3 parameetrist: teha, arv1, arv2. Kastuta if konstruktsioon. Tulemus kuva ekraanile.
//        public static int Korrutamine(int arv1, int arv2)
//        {
//            return arv1 * arv2;
//        }
//        public static int Lahutamine(int arv1, int arv2)
//        {
//            return arv1 - arv2;
//        }
//        public static int Jagamine(int arv1, int arv2)
//        {
//            return arv1 / arv2;
//        }
//    }
//}


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
        public static string Pikkuse_analuus(double pikkus)
        {
            string analuus;
            if (pikkus < 1.6)
            {
                analuus = "Lühika kasvu inimene";
            }
            else if (pikkus < 1.8)
            {
                analuus = "Keskmine kasvu inimene";
            }
            else
            {
                analuus = "Pikka kasvu inimene";
            }
            return analuus;
        }
        //päeva number->päeva nimetus
        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1: paev = "Esmaspaev"; break;
                case 2: paev = "Teisipaev"; break;
                case 3: paev = "Kolmapaev"; break;
                case 4: paev = "Neljapaev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupaev"; break;
                case 7: paev = "Pühapaev"; break;
                default:
                    paev = "Ei saa määrata";
                    break;
            }
            return paev;
        }
        //ÜLESAND 1
        public static int[] Arvude_massiv(int N, int M)
        {
            int arv;
            int[] arvud= new int [M-N];
            for (int i = 0; i < arvud.Length ; i++ )
            {
                Console.WriteLine ("{0} :", i + 1);
                arv = N;
                arvud[i] = arv;
                N++;
            }
            return arvud;
        }

        //Ülesand 4
        public static void ostaElevant()
        {
            string kasutajasisend;

            do
            {
                Console.WriteLine("Osta elevant ära!");

                kasutajasisend = Console.ReadLine();
            }
            while (!string.Equals(kasutajasisend, "elevant", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Kasutaja sisestas elevant!");
        }
    }
}


