using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //HashTable
        //Tanımlama
        var sehirler = new Hashtable();

        //Ekleme
        sehirler.Add(6, "Ankara");
        sehirler.Add(34, "İstanbul");
        sehirler.Add(16, "Bursa");
        sehirler.Add(31, "Hatay");

        //Verilerde dolaşma
        Console.WriteLine("HashTable : Key + Value");
        foreach (DictionaryEntry sehir in sehirler)
        {
            Console.WriteLine(sehir.Key + " " + sehir.Value);
        }
        Console.WriteLine();

        Console.WriteLine("Anahtarlar: Keys");
        var anahtarlar = sehirler.Keys;
        foreach (var key in anahtarlar)
        {
            Console.WriteLine(key);
        }
        Console.WriteLine();

        Console.WriteLine("Değerler: Values");
        ICollection degerler = sehirler.Values;
        foreach (var value in degerler)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();

        Console.WriteLine("Eleman Sayısı:");
        Console.WriteLine(sehirler.Count);
        Console.WriteLine();

        Console.WriteLine("Elemana Erişme:");
        Console.WriteLine(sehirler[16]);
        Console.WriteLine();

        Console.WriteLine("Eleman Silme:");
        sehirler.Remove(6);
        foreach (DictionaryEntry sehir in sehirler)
        {
            Console.WriteLine(sehir.Key + " " + sehir.Value);
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("HashTable UYGULAMASI:"); 
        // HashTable UYGULAMASI
        // Başlığı okuma
        Console.Write("Türkçe Karakter ve ' ? boşluk gibi karakterler içeren Başlığı Girin: " );
        string baslik = Console.ReadLine();

        //küçültme
        baslik = baslik.ToLower();

        // HashTable
        var KarakterSeti = new Hashtable()
        {
            {'\'', '-' },
            {'.', '-' },
            {' ', '-' },
            {'?', '-' },
            {'ç', 'c' },
            {'Ç', 'C' },
            {'ş', 's' },
            {'Ş', 'S' },
            {'ı', 'i' },
            {'İ', 'I' },
            {'ö', 'o' },
            {'Ö', 'O' },
            {'ü', 'u' },
            {'Ü', 'U' },
            {'ğ', 'g' },
            {'Ğ', 'G' }
        };

        foreach (DictionaryEntry karakter in KarakterSeti)
        {
            baslik = baslik.Replace((char)karakter.Key, (char)karakter.Value);
        }

        Console.WriteLine(baslik);
    }


}