using System;

namespace DegiskenlerIleUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz.");
            Console.Write("T.C. Kimlik numaranız: ");
            string TC = Console.ReadLine();

            Console.Write("Ad: ");
            string ad = Console.ReadLine();

            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            Console.Write("Telefon: ");
            string telefon = Console.ReadLine();

            Console.Write("Yaş: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("İlk ürün fiyatı : ");
            double u1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci ürün fiyatı : ");
            double u2 = Convert.ToDouble(Console.ReadLine());

            double toplam = u1 + u2;
            double puan = (u1 + u2) * 0.10;

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine($"{TC} T.C. nolu {ad} {soyad} isimli kişi için kayıt oluşturulmuştur. ");
            Console.WriteLine($"{telefon} numarasına bildirim gönderilmiştir.");
            Console.WriteLine($"{toplam} toplam harcama karşılığında kazanılan 10% patika puanı {puan} 'dır.");


        }
    }
}
