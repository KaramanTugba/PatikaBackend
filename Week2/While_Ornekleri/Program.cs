using System;

namespace While_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1--------------------------------------");

            int i = 0;

            while (i<10)
            {

                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim.");
                i++;
            }
            


            Console.WriteLine("2--------------------------------------");

            int j = 1;
            while (j<21)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("3--------------------------------------");

            int z = 1;
            while (z < 21)
            {
                if (z%2==0)
                {
                Console.WriteLine(z);
               
                }
                z++;
            }

            Console.WriteLine("4--------------------------------------");

            int a = 50;
            int top = 0;
            while (a<151)
            {
                top = top + a;
                a++;
            }
            Console.WriteLine(top);


            Console.WriteLine("5--------------------------------------");
            int b = 1;
            int cifttop = 0;
            int tektop = 0;

            while (b < 120)
            {

                if (b%2==0)
                {
                    cifttop = cifttop + b;
                    b++;
                }
                else
                {
                    tektop = tektop + b;
                    b++;
                }

               
            }
            Console.WriteLine("Çif Toplam : "+cifttop+" Tek Toplam: "+tektop);

        }
    }
}
