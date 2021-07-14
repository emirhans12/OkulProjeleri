using System;

namespace _14._07._2021_Tam_Sayı_İslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, asonuc, bsonuc;
            Console.Write("1. Sayıyı Giriniz = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz = ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("İlk Sayımız pozifitir");
                //asonuc = Convert.ToInt32(Console.ReadLine());
                asonuc = a * a * a;
                Console.WriteLine("1. Sayının Küpü = " + asonuc);

            }
            else
            {
                Console.WriteLine("İlk Sayımız negatiftir");
                //asonuc = Convert.ToInt32(Console.ReadLine());
                asonuc = a * a;
                Console.WriteLine("1. Sayının Kendisi ile çarpımı = " + asonuc);

            }
            if (b>0)
            {
                Console.WriteLine("İkinci Sayımız pozifitir");
                //asonuc = Convert.ToInt32(Console.ReadLine());
                asonuc = a +b;
                Console.WriteLine("1. Sayı İle 2. Sayının Toplamı = " + asonuc);
            }
            else
            {
                Console.WriteLine("İkinci Sayımız negatiftir");
                //asonuc = Convert.ToInt32(Console.ReadLine());
                asonuc = a - b;
                Console.WriteLine("1. Sayı İle 2. Sayının Farkı = " + asonuc);
            }
            if (a>0 && b<=1)                
            {
                if (a>b)
                {
                    Console.WriteLine("En Büyük Sayı = "+a);
                }
                else
                {
                    Console.WriteLine("En Büyük Sayı = "+b);
                }
                

            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("En Küçük Sayı = "+a);
                }
                else
                {
                    Console.WriteLine("En Küçük Sayı = "+b);
                }
            }
            if (a>0 || a==0 || b<1)
            {
                if (a % 2 == 0)
                {
                    Console.Write("İlk sayı çifttir");
                }
                else
                {
                    Console.Write("İlk sayı tektir");
                }
            }
            else
            {
                asonuc = a * a + b * b;
                Console.Write("a.a+b.b formülünün sonucu = "+asonuc);
            }
            Console.ReadKey();



        }
    }
}
