using System;

namespace IlkMetot
{
    class Program
    {
        static void Main(string[] args)
        {

        void SarkiSozu()
            {

                Console.WriteLine("Hayat bazen tatlıdır.");
            }



        double TamSayi()
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);

                double kalan = sayi / 2;
                return kalan;

            }

        int Carpma(int a, int b)
            {
                int carp = a * b;
                return carp;
            }

        
        void Yazi(string i, string s)
            {
                Console.WriteLine($"Hoşgeldiniz {i} {s}");
            }




            Console.WriteLine("-------------------1----------------------");
            SarkiSozu();

            Console.WriteLine("-------------------2----------------------");
            Console.WriteLine(TamSayi());

            Console.WriteLine("-------------------3----------------------");

            Console.WriteLine("Sayı giriniz");
            int bir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı giriniz");
            int iki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Carpma(bir,iki));


            Console.WriteLine("-------------------4----------------------");

            Console.WriteLine("İsim giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyad giriniz");
            string soyad = Console.ReadLine();
            Yazi(isim,soyad);




        }
    }
}
