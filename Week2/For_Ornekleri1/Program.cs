using System;

namespace For_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1--------------------------------------");

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim.");
            }

            Console.WriteLine("2--------------------------------------");

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("3- -------------------------------------");

            for (int i = 1; i < 21; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("4- -------------------------------------");
            int top = 0;
            for (int i = 50; i < 151; i++)
            {

                top = top + i;
            }

            Console.WriteLine("50-150 arası top: " + top);


            Console.WriteLine("5- -------------------------------------");
            int cifttop = 0;
            int tektop = 0;
            for (int i = 50; i < 151; i++)
            {
                if (i % 2 == 0)
                {
                    cifttop = cifttop + i;

                }
                else
                {

                    tektop = tektop + i;
                }


            }

            Console.WriteLine("Çift Sayı Toplamı : " + cifttop + " , Tek Sayı Toplamı : " + tektop);
        }
    }
}
