using System;

namespace Sifre_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kullaniciadi, sifre;
            don:
            Console.WriteLine("Kullanıcı adını giriniz: ");
            kullaniciadi = Console.ReadLine();
            if (kullaniciadi == "vedat")
            {
                Console.WriteLine("Kullanıcı adı doğru.");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı doğru değildir. ");
                goto don;
            }
            don1:
            Console.WriteLine("Kullanıcı şifresini giriniz: ");
            sifre = Console.ReadLine();

            
            if (sifre == "834")
            {
                Console.WriteLine("Şifre doğru.");
                Console.WriteLine("Giriş Başarılı.");
            }
            else
            {
               
                Console.WriteLine("Şifre doğru değil. ");
                Console.WriteLine("Giriş başarılı değil");
                goto don1;
                
            }
            


            Console.ReadKey();

        }
    }
}
