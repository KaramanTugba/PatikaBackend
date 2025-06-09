using System;

namespace KimMilyonerOlmakIster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster");
            Console.WriteLine("-----------------------------------------------------");


            int dogru = 0;


            do
            {

           
           

                Console.WriteLine("1. Ateş Yakmak adlı kitabın yazarı kimdir?");
                Console.WriteLine("a. Jack London           b.Kathleen Sears");

                string cevap1 = Console.ReadLine().ToLower();

                if (cevap1 == "a")
                {
                    dogru++;
                    Console.WriteLine("Cevap doğru ");
                }
                else
                {
                    Console.WriteLine("Cevap yanlış, doğru cevap A "+dogru);

                }


                Console.WriteLine("2. Siyah İnci adlı kitabın yazarı kimdir?");
                Console.WriteLine("a. Anna Sewell           b.James Clear");

                string cevap2 = Console.ReadLine().ToLower();

                if (cevap2 == "a")
                {
                    dogru++;
                    Console.WriteLine("Cevap doğru");
                    if(dogru == 2)
                    {
                        break;
                       
                    }
                }
                else
                {
                    Console.WriteLine("Cevap yanlış, doğru cevap A");

                }

                Console.WriteLine("3. Hilal Şehir adlı kitabın yazarı kimdir?");
                Console.WriteLine("a. Anna Sewell           b.Sarah J. Maas");

                string cevap3 = Console.ReadLine().ToLower();

                if (cevap2 == "b")
                {
                    dogru++;
                    Console.WriteLine("Cevap doğru");
                    if (dogru == 2)
                    {
                        break;

                    }
                }
                else
                {
                    Console.WriteLine("Cevap yanlış, doğru cevap B");
                    break;
                }

                break;

            } while (dogru == 2);


            if (dogru == 2)
            {
            Console.WriteLine("Kazandın");

            }
            else
            {

            Console.WriteLine("Kaybettin");
            }



        }
    }
}
