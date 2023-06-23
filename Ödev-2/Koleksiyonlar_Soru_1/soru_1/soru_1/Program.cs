using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> asalSayilar = new List<int>();
        List<int> asalOlmayanSayilar = new List<int>();

        int adet = 0;

        while (adet < 20)
        {
            Console.Write("Pozitif bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out int girilenSayi) && girilenSayi > 0)
            {
                bool asalMi = true;
                for (int i = 2; i <= Math.Sqrt(girilenSayi); i++)
                {
                    if (girilenSayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }

                if (asalMi)
                    asalSayilar.Add(girilenSayi);
                else
                    asalOlmayanSayilar.Add(girilenSayi);

                adet++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }
        }

        asalSayilar.Sort();
        asalOlmayanSayilar.Sort();
        asalSayilar.Reverse();
        asalOlmayanSayilar.Reverse();

        Console.WriteLine("Asal Sayılar:");
        foreach (int sayi in asalSayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Asal Olmayan Sayılar:");
        foreach (int sayi in asalOlmayanSayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Asal Sayıların Eleman Sayısı: " + asalSayilar.Count);
        Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı: " + asalOlmayanSayilar.Count);

        double asalOrtalama = asalSayilar.Count > 0 ? asalSayilar.Average() : 0;
        double asalOlmayanOrtalama = asalOlmayanSayilar.Count > 0 ? asalOlmayanSayilar.Average() : 0;

        Console.WriteLine("Asal Sayıların Ortalaması: " + asalOrtalama);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + asalOlmayanOrtalama);

        Console.ReadLine();
    }
}
