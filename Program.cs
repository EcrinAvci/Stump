using Microsoft.ML;
using Microsoft.ML.Data;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan veri al
        Console.Write("Kütük boyunu girin (cm): ");
        float kutuk_boyu = float.Parse(Console.ReadLine() ?? "0");

        Console.Write("Kaç kütük işlenecek?: ");
        int kutuk_adedi = int.Parse(Console.ReadLine() ?? "1");

        Console.Write("Testere payını girin (cm): ");
        float testere_payi = float.Parse(Console.ReadLine() ?? "0.1");

        Console.Write("Her kütük kaç parçaya bölünecek? (1-3): ");
        int parca_sayisi = int.Parse(Console.ReadLine() ?? "1");
        if (parca_sayisi < 1) parca_sayisi = 1;
        if (parca_sayisi > 3) parca_sayisi = 3;

        // Parça boylarını al
        float[] parca_boylari = new float[3];
        for (int i = 0; i < parca_sayisi; i++)
        {
            Console.Write($"{i + 1}. parça boyunu girin (cm): ");
            parca_boylari[i] = float.Parse(Console.ReadLine() ?? "0");
        }
        // Eksik parça varsa 0 ile doldur
        for (int i = parca_sayisi; i < 3; i++)
            parca_boylari[i] = 0;

        // Toplam kütük boyu hesapla
        float toplam_kutuk_boyu = kutuk_boyu * kutuk_adedi;

        // Kullanıcıdan her parça için kaç adet istediğini al
        int[] adetler = new int[3];
        for (int j = 0; j < parca_sayisi; j++)
        {
            Console.Write($"Parça {j + 1} için kaç adet kesilecek?: ");
            adetler[j] = int.Parse(Console.ReadLine() ?? "0");
        }

        // Toplam kullanılan uzunluk ve toplam kesim sayısı
        float toplam_kullanilan_uzunluk = 0;
        int toplam_kesim = 0;
        for (int j = 0; j < parca_sayisi; j++)
        {
            toplam_kullanilan_uzunluk += adetler[j] * parca_boylari[j];
            toplam_kesim += adetler[j];
        }
        // Toplam testere kaybı (her parça arasında kesim var, son parçada yok)
        int toplam_testere_kaybi = (toplam_kesim > 0 ? toplam_kesim - 1 : 0) * (int)testere_payi;
        float toplam = toplam_kullanilan_uzunluk + toplam_testere_kaybi;
        float fire = toplam_kutuk_boyu - toplam;

        Console.WriteLine("\nSonuçlar:");
        Console.WriteLine($"  Toplam kütük boyu: {toplam_kutuk_boyu} cm ({kutuk_adedi} kütük × {kutuk_boyu} cm)");
        if (toplam > toplam_kutuk_boyu)
        {
            Console.WriteLine("  Bu kombinasyon toplam kütüğe sığmaz!");
        }
        else
        {
            for (int j = 0; j < parca_sayisi; j++)
            {
                Console.WriteLine($"  Parça {j + 1}: {adetler[j]} adet, boy: {parca_boylari[j]} cm");
            }
            Console.WriteLine($"  Toplam testere kaybı: {toplam_testere_kaybi} cm");
            Console.WriteLine($"  Fire (artık): {fire:F2} cm");

            // Artık kütükten ekstra parça çıkarma optimizasyonu
            if (fire > 0)
            {
                Console.WriteLine("\n=== EKSTRA OPTİMİZASYON ===");
                float kalan_boy = fire;
                int[] ekstra_adetler = new int[3];
                int ekstra_testere_kaybi = 0;
                bool eklendi = true;
                while (eklendi)
                {
                    eklendi = false;
                    for (int j = 0; j < parca_sayisi; j++)
                    {
                        if (kalan_boy >= parca_boylari[j] + (ekstra_adetler[j] + adetler[j] > 0 ? testere_payi : 0) && parca_boylari[j] > 0)
                        {
                            if (ekstra_adetler[j] + adetler[j] > 0)
                            {
                                kalan_boy -= testere_payi;
                                ekstra_testere_kaybi += (int)testere_payi;
                            }
                            kalan_boy -= parca_boylari[j];
                            ekstra_adetler[j]++;
                            eklendi = true;
                        }
                    }
                    if (!eklendi) break;
                }
                float final_fire = kalan_boy;
                bool ekstra_parca_var = false;
                for (int j = 0; j < parca_sayisi; j++)
                {
                    if (ekstra_adetler[j] > 0)
                    {
                        ekstra_parca_var = true;
                        break;
                    }
                }
                if (ekstra_parca_var)
                {
                    Console.WriteLine("  Artık kütükten ekstra üretilebilecek:");
                    for (int j = 0; j < parca_sayisi; j++)
                    {
                        if (ekstra_adetler[j] > 0)
                        {
                            Console.WriteLine($"    Parça {j + 1}: +{ekstra_adetler[j]} adet (toplam: {adetler[j] + ekstra_adetler[j]} adet)");
                        }
                    }
                    Console.WriteLine($"  Ekstra testere kaybı: {ekstra_testere_kaybi} cm");
                    Console.WriteLine($"  Final fire: {final_fire:F2} cm");
                }
                else
                {
                    Console.WriteLine("  Artık kütükten ekstra parça çıkarılamaz.");
                }
            }
        }
    }
}