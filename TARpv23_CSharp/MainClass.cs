using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ////I.osa Andmetüübid, Alamfunktsioonid, If
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Hello, World!");
            //string nimetus = "Python";
            //Console.WriteLine("Hello, {0}", nimetus);
            //Funktsioonid.Tere(nimetus);
            //Console.Write("Sisesta esimene arv: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Sisesta teine arv: ");
            //int b = int.Parse(Console.ReadLine());
            //int vastus = Funktsioonid.Liitmine(a, b);
            //Console.WriteLine(vastus);
            //double arv = 5.123456;
            //vastus = Funktsioonid.Liitmine(a, (int)arv);
            //Console.WriteLine(vastus);
            //char taht = 'A';
            //if (vastus == 0)
            //{
            //    Console.WriteLine(taht);
            //}
            //else
            //{
            //    Console.WriteLine(vastus);
            //}
            //// Loo Arvuta() funktsioon, mis sõltub 3 parameetrist: teha, arv1, arv2, kasuta if konstruktsioon. Tulemus kuva ekraanile.

            ////1. Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
            //try
            //{
            //    Console.WriteLine("Mis on sinu pikkus?");
            //    double pikkus = Double.Parse(Console.ReadLine());
            //    string vastus0 = Funktsioonid.Pikkuse_analuus(pikkus);
            //    Console.WriteLine("Sinu pikkus on {0} m, sa oled {1}", pikkus, vastus0);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            ////masiv
            //string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Yuku" };
            //nimed[0] = "Marian";
            ////1 v.
            //for (int i = 0; i < nimed.Length; i++)
            //{
            //    Console.WriteLine(nimed[i]);
            //}
            ////2 v.
            //foreach (string nimi in nimed)
            //{
            //    Console.WriteLine(nimi);
            //}
            ////3 v.
            //int n = 0;
            //while (n < nimed.Length)
            //{
            //    Console.WriteLine(nimed[n]);
            //    n++;
            //}
            ////4 v.
            //do
            //{
            //    Console.WriteLine(nimed[n - 1]);
            //    n--;
            //} while (n > 0);

            ////Paevad
            //Random random = new Random();
            //for (int i = 0; i < 7; i++)
            //{
            //    int paev_nr = random.Next(-4, 30);
            //    string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
            //    Console.WriteLine(paeva_nimetus);
            //}

            ////Ülesand 1

            //int N = random.Next(-100, 101);
            //int M = random.Next(-100, 101);
            //int[] arvud;

            //if (N < M)
            //{
            //    arvud = Funktsioonid.Arvude_massiv(N, M);
            //}
            //else
            //{
            //    arvud = Funktsioonid.Arvude_massiv(M, N);
            //}
            //foreach (int item in arvud)
            //{
            //    Console.Write(item * item);
            //}


            ////Ülesand 4


            ////Ülesand 5 - Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.
            //int arvuti_arv = random.Next(1, 50);
            //int kasutaja_arv;
            //int katsed = 0;
            //bool arvatiOigesti = false;
            //Console.WriteLine("f");

            //while (katsed < 5 && !arvatiOigesti)
            //{
            //    Console.WriteLine("Sisesta oma arvasta arv : ");
            //    kasutaja_arv = int.Parse(Console.ReadLine());
            //    katsed++;

            //    if (kasutaja_arv == arvuti_arv)
            //    {
            //        Console.WriteLine("Õige");
            //        arvatiOigesti = true;
            //    }
            //    else if (kasutaja_arv < arvuti_arv)
            //    {
            //        Console.WriteLine("Liiga väike!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Liiga suur!");
            //    }

            //    if (arvatiOigesti = false)
            //    {
            //        Console.WriteLine($"sa ei arvanud ära, mõistatatud arv - {arvuti_arv}");
            //    }
            //}
            //// 6* Kūsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv
            //int[] neliArvu = new int[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Sisesta arv {0}: ", i + 1);
            //    neliArvu[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(neliArvu);
            //Array.Reverse(neliArvu);
            //string suurimArv = string.Join("", neliArvu);
            //Console.WriteLine("Suurin võimalik neliarvuline arv; " + suurimArv);


            ////II osa. listid ja sõnastikud
            //Random random1 = new Random();
            //List<string> abc = new List<string>();
            //try
            //{
            //    foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
            //    {
            //        abc.Add(rida);
            //    }

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Fail ei saa lisada");
            //}
            //foreach (string e in abc)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.ReadLine();


            ////
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Esimene");
            //arrayList.Add("Teine");
            //arrayList.Add("Kolmas");
            //Console.WriteLine("Otsing :");
            //string vas = Console.ReadLine();

            //if (vas != null && arrayList.Contains(vas))
            //{
            //    Console.WriteLine("otsing element asub" + arrayList.IndexOf(vas) + "kohal");
            //}
            //else
            //{
            //    Console.WriteLine("Kokku oli" + arrayList.Count + "elemente, vaid otsitav puudub");
            //}
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Insert(0, "Inna");
            //arrayList1.Insert(1, "Anna");
            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}
            ////arrayList.Clear();
            ////arrayList.Insert(1, "Anna");
            ////arrayList.Insert(0, "Mati");
            ////Console.WriteLine(arrayList);


            ////III. osa OOP
            //List<Inimene> inimesed = new List<Inimene>();
            //Inimene inimene1 = new Inimene();
            //inimene1.Nimi = "Pjotr I";
            //inimene1.Vanus = 352;
            //Inimene inimene2 = new Inimene("Jelizaveta");
            //inimene2.Vanus = 98;
            //Inimene inimene3 = new Inimene("Marina", 18);
            //inimesed.Add(inimene1);
            //inimesed.Add(inimene2);
            //inimesed.Add(inimene3);
            //inimesed.Add(new Inimene("Irina", 18));
            //foreach (Inimene inimene in inimesed)
            //{
            //    Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + "aasta vana");
            //}


            //Auto1 auto1 = new Auto1("584 HRY", Color.NavajoWhite, inimene1);
            //Auto1 auto2 = new Auto1("584 HRY", Color.DeepPink, inimene2);
            //Auto1 auto3 = new Auto1("584 HRY", Color.DarkRed, inimene3);
            //auto1.KelleOmaAuto();
            //Dictionary<Auto1, Inimene> register = new Dictionary<Auto1, Inimene>();
            //register.Add(auto1, inimene1);
            //register.Add(auto2, inimene2);
            //register.Add(auto3, inimene3);
            //foreach (var item in register)
            //{
            //    Console.WriteLine($"{item.Key.Regnumber} - {item.Value.Nimi}");
            //}
            //foreach (KeyValuePair<Auto1, Inimene> pair in register)
            //{
            //    Console.WriteLine(pair.Key.Regnumber + "-" + pair.Value.Nimi);
            //}

            //// II Ülesanne
            //Random random2 = new Random();
            //List<int> numbrid = new List<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    numbrid.Add(random2.Next(0, 101));
            //}
            //List<int> paarisNumbrid = numbrid.Where(n => n % 2 == 0).ToList();
            //List<int> parituNumbrid = numbrid.Where(n => n % 2 != 0).ToList();
            //List<int> sortNumbrid = paarisNumbrid.Concat(parituNumbrid).ToList();
            //Console.WriteLine("Sorteeritud numbers : ");
            //sortNumbrid.ForEach(n => Console.WriteLine(n + " "));


            //// I Ülesanne
            //Console.WriteLine("Sisesta numbrid");
            //string numbstr = Console.ReadLine();
            //string[] numblist = numbstr.Split(" ");
            //int[] newlist = new int[numblist.Length];
            //for (int i = 0; i < numblist.Length; i++)
            //{
            //    int a1;
            //    if (i == 0)
            //    {
            //        a1 = int.Parse(numblist[numblist.Length - 1]) + int.Parse(numblist[i + 1]);
            //    }
            //    else if (i == numblist.Length - 1)
            //    {
            //        a1 = int.Parse(numblist[i - 1]) + int.Parse(numblist[0]);
            //    }
            //    else
            //    {
            //        a1 = int.Parse(numblist[i - 1]) + int.Parse(numblist[i + 1]);
            //    }
            //    newlist[i] = a1;
            //}
            //Console.WriteLine("New list of sums");
            //Console.WriteLine(string.Join(", ", newlist));

            //III Ülesanne

            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new("Valeria", 17, Sugu.Naine);
            Inimene inimene2 = new("Daria", 17, Sugu.Naine);
            Inimene inimene3 = new("Aleksandra", 16, Sugu.Naine);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            Console.WriteLine("Mis on sinu eluviis? 0-4");
            inimene1.Aktiivsus = (Aktiivsus)Convert.ToInt32(Console.ReadLine());
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + " aasta vana. " + "Ta on " + inimene.Sugu + ". SBI= " + inimene.kaloriteArvutamine(inimene.Aktiivsus) + ". Aktiivsusu = " + inimene.Aktiivsus);
            }


        }
    }
}

                                      
