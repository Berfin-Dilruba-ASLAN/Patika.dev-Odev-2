using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        List<char> sesliHarfler = new List<char>();

        foreach (char harf in cumle)
        {
            if (IsSesliHarf(harf))
            {
                sesliHarfler.Add(harf);
            }
        }

        sesliHarfler.Sort();

        Console.WriteLine("Sesli harfler:");
        foreach (char harf in sesliHarfler)
        {
            Console.WriteLine(harf);
        }
    }

    static bool IsSesliHarf(char harf)
    {
        harf = Char.ToLower(harf);

        return harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' ||
               harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü';
    }
}
