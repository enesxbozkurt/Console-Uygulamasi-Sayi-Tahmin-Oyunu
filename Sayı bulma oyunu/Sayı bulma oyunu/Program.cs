using System;

namespace Sayı_bulma_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Tahmin Et";
            int tahmin = 0;
            int sayi;
            int sayac = 0;
            Random rastgele = new Random();
            Console.WriteLine("Bir Sayı Girin..");
            sayi = rastgele.Next(1, 20);
            while(tahmin != sayi)
            {
                tahmin = Convert.ToInt16(Console.ReadLine());
                sayac++;
                if (tahmin < sayi)
                {
                    Console.WriteLine("Daha Büyük Bir Sayi Girin");
                }
                else if(tahmin > sayi)
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Girin");
                }
            }
            Console.WriteLine("Tebrikler Sayiyi {0}. denemede buldunuz",sayac);
            Console.Read();
        }
    }
}
