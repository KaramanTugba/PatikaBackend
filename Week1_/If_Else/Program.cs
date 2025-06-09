using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("Girilen sayi 10 dan büyüktür");
            }
            else
            {
                    
                Console.WriteLine("Girilen sayi 10 a eşit yada küçüktür.");
            }


            if (sayi % 2 == 0 )
            {
                Console.WriteLine("Girilen sayi çifttir");
            }
            else
            {

                Console.WriteLine("Girilen sayi tektir");
            }




        }
    }
}
