using System;

namespace WhileVSDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı giriniz:. ");
            int a = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(a);

            int sayac = 0;
            Console.WriteLine("While");
            while (sayac <= a )
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            }

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Do While");
            sayac = 0;
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            } while (sayac <= a);


        }
    }
}
