using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //1 osa Andmetüübid, Alamfunktsioonid, If
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Vali tegevus (L-Liitmine, K-Korrutamine, La-Lahutamine, J-Jagamine): ");
            string v =(Console.ReadLine());
            Console.Write("Sisesta esimene arv: ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus=Funktsioonid.Liitmine(a,b);
            int vastus1 = Funktsioonid.Korrutamine(a, b);
            Console.WriteLine(vastus);
            Console.WriteLine(vastus1);
            double arv = 5.123456;
            vastus=Funktsioonid.Liitmine(a,(int)arv);
            vastus1= Funktsioonid.Korrutamine(a, (int)arv);
            Console.WriteLine(vastus);
            Console.WriteLine(vastus1);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }
            
        }
    }
}
