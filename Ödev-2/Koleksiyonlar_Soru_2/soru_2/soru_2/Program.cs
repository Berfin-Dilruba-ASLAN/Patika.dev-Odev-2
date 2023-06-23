using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];

        // Kullanıcıdan 20 adet sayıyı alın
        Console.WriteLine("Lütfen 20 adet sayı girin:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Sayı {0}: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sayıları küçükten büyüğe sırala
        Array.Sort(numbers);

        // En küçük 3 sayıyı alın
        int[] minNumbers = new int[3];
        Array.Copy(numbers, minNumbers, 3);

        // En büyük 3 sayıyı alın
        int[] maxNumbers = new int[3];
        Array.Copy(numbers, numbers.Length - 3, maxNumbers, 0, 3);

        // En küçük 3 sayıların ortalamasını hesapla
        double minAverage = CalculateAverage(minNumbers);

        // En büyük 3 sayıların ortalamasını hesapla
        double maxAverage = CalculateAverage(maxNumbers);

        // Ortalama toplamlarını hesapla
        double totalAverage = (minAverage + maxAverage) / 2;

        // Sonuçları ekrana yazdır
        Console.WriteLine("En küçük 3 sayı: {0}", string.Join(", ", minNumbers));
        Console.WriteLine("En büyük 3 sayı: {0}", string.Join(", ", maxNumbers));
        Console.WriteLine("En küçük 3 sayıların ortalaması: {0}", minAverage);
        Console.WriteLine("En büyük 3 sayıların ortalaması: {0}", maxAverage);
        Console.WriteLine("Ortalama toplamı: {0}", totalAverage);
    }
    static double CalculateAverage(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return (double)sum / numbers.Length;
    }
}