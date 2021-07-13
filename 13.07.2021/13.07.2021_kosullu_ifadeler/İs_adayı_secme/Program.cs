using System;

namespace İs_adayı_secme
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas;
            string key;
            Console.WriteLine("İş Adayı Seçme Programı");
            Console.WriteLine("--------------------------------");
            
            Console.WriteLine("Yaşınızı Giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());
            if (yas < 40)
            {
                Console.WriteLine("Yaşınız İşe girmek için doğru ☺");

            }
            else
            {
                Console.WriteLine("Yaşınız İşe girmek için doğru değildir !!!");
                Console.ReadKey();
                Console.ReadLine();
                Console.Read();


            }
            
            Console.WriteLine("Üniversite Okudunuz mu ?");
            Console.WriteLine("Evet ise y tuşuna Hayır ise n tuşuna basınız");
            key= Console.ReadLine();


            if (key == "y" || key == "Y")
            {
                Console.WriteLine("Tamam Devam Edelim.");
                
            }
            if (key == "n" || key == "N")
            {
                Console.WriteLine("Üzgünüm iş yerine uygun biri değilsiniz.");
                Console.WriteLine("---İşleminiz Bitmiştir --- İyi Günler---.");
                Console.ReadKey();
                Console.ReadKey();
                Console.ReadLine();
                Console.Read();
            }
            Console.WriteLine("Ehliyetiniz var mı ?");
            Console.WriteLine("Evet ise y tuşuna Hayır ise n tuşuna basınız");
            key = Console.ReadLine();


            if (key == "y" || key == "Y")
            {
                Console.WriteLine("Tamam Devam Edelim.");

            }
            if (key == "n" || key == "N")
            {
                Console.WriteLine("Üzgünüm iş yerine uygun biri değilsiniz.");
                Console.WriteLine("---İşleminiz Bitmiştir --- İyi Günler---.");
                Console.ReadKey();
                Console.ReadKey();
                Console.ReadLine();
                Console.Read();
            }
            Console.WriteLine("Cinsiyetiniz nedir ?");
            Console.WriteLine("Erkek ise E tuşuna Kadın ise K tuşuna basınız");
            key = Console.ReadLine();


            if (key == "k" || key == "K")
            {
                Console.WriteLine("Tamam Devam Edelim.");

            }
            if (key == "e" || key == "E")
            {
                Console.WriteLine("Üzgünüm iş yerine uygun biri değilsiniz.");
                Console.WriteLine("---İşleminiz Bitmiştir --- İyi Günler---.");
                Console.ReadKey();
                Console.ReadLine();
                Console.Read();
            }
            //if (key == "n" || key == "N")
            //{
            //    Console.WriteLine("Üzgünüm iş yerine uygun biri değilsiniz.");
            //    Console.WriteLine("---İşleminiz Bitmiştir --- İyi Günler---.");

            /*if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            if (Console.ReadKey().Key == ConsoleKey.E)
            {
                Environment.Exit(0);
            }
            */
        }
            }
        }
    

