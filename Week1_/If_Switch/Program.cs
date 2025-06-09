using System;

namespace If_Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Manava Hoşgeldiniz!");


            Console.WriteLine("--------------------");
            Console.WriteLine("elma : 2");
            Console.WriteLine("armut : 3");
            Console.WriteLine("çilek : 2");
            Console.WriteLine("muz : 3");
            Console.WriteLine("diğer meyveler : 4");




            Console.WriteLine("--------------------");
            Console.Write("Hangi meyveyi satın almak istiyorsunuz? (elma,armut,çilek,muz)");
            string meyve = Console.ReadLine().ToLower();

            int fiyat;

            ///// if ile

            if (meyve == "elma")
            {
                fiyat = 2;
            }
            else if (meyve == "armut")
            {
                fiyat = 3;
            }
            else if (meyve == "çilek")
            {
                fiyat = 2;
            }
            else if (meyve == "muz")
            {
                fiyat = 3;
            }
            else
            {
                fiyat = 4;
            }

            Console.WriteLine($"Meyve {meyve}, fiyatı {fiyat}.");


            ///// switch ile
            ///

            switch (meyve)
            {
                case "elma":
                    fiyat = 2;
                    break;
                case "armut":
                    fiyat = 3;
                    break;
                case "çilek":
                    fiyat = 2;
                    break;
                case "muz":
                    fiyat = 3;
                    break;
                default:
                    fiyat = 4;
                    break;
            }

            Console.WriteLine($"Meyve {meyve}, fiyatı {fiyat}.");








        }
    }
}
