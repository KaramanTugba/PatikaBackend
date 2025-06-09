using System;

namespace YolArkadasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yol Arkadaşı : Tatil Uygulaması");

            string b = "Bodrum : Paket başlangıç fiyatı 4000 TL";
            string m = "Marmaris : Paket başlangıç fiyatı 3000 TL";
            string c = "Çeşme : Paket başlangıç fiyatı 5000 TL";
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(b);
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.WriteLine("----------------------------------------------------");

            while (true)
            {
                string lokasyon = "";
                int kisiSayisi = 0;
                int lokasyonFiyat = 0;


                while (true)
                {
                    Console.WriteLine("Lokasyon giriniz:");
                    lokasyon = Console.ReadLine().ToLower();

                    if (lokasyon == "bodrum")
                    {
                        lokasyonFiyat = 4000;
                        lokasyon = "Bodrum";
                        break;
                    }
                    else if (lokasyon == "marmaris")
                    {
                        lokasyonFiyat = 3000;
                        lokasyon = "Marmaris";
                        break;
                    }
                    else if (lokasyon == "çeşme")
                    {
                        lokasyonFiyat = 5000;
                        lokasyon = "Çeşme";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı lokasyon Tekrar deneyiniz.");
                    }
                }

                while (true)
                {
                    Console.Write("Kiş sayısı giriniz: ");
                    string giris = Console.ReadLine();

                    if (kisiSayisi > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir sayı giriniz.");
                    }
                }

                Console.WriteLine($"{lokasyon} Tatil Özeti");
                switch (lokasyon.ToLower())
                {
                    case "bodrum":
                        Console.WriteLine("3 gün deniz, güneş, gece hayatı ve tarihi yerler sizi bekliyor.");
                        break;
                    case "marmaris":
                        Console.WriteLine("Doğa yürüyüşleri, tekne turları ve plaj keyfi yapabilirsiniz.");
                        break;
                    case "çeşme":
                        Console.WriteLine("Alaçatı sokaklarında dolaşabilir, rüzgar sörfü yapabilirsiniz.");
                        break;
                }

                int ulasimTutari = 0;

                while (true)
                {
                    Console.WriteLine("Ulaşım yöntemi seçiniz.");
                    Console.WriteLine("1 - Kara yolu (Kişi başı 1500 TL)");
                    Console.WriteLine("2 - Hava yolu (Kişi başı 4000 TL)");
                    Console.Write("1,2: ");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        ulasimTutari = 1500;
                        break;
                    }
                    else if (secim == 2)
                    {
                        ulasimTutari = 4000;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı, tekrar seçiniz.");
                    }
                }

                int toplamTutar = kisiSayisi * (lokasyonFiyat + ulasimTutari);
                Console.WriteLine($"Toplam tutar = {toplamTutar} TL");

              }
        }
    }
}
