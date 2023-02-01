using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            soru6_BankadanParaCek();
            Console.ReadKey();
        }
        static void soru1_Carpmaİslemi()
        {
            //çarpma işlemini kullanmadan sadece toplam işlemi kullanarak çarpma
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            int sonuc = 0, birinciSayi, ikinciSayi;
            Console.WriteLine("Carpilacak 1. sayiyi giriniz : ");
            birinciSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Carpilacak 2. sayiyi giriniz : ");
            ikinciSayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= birinciSayi; i++)
                sonuc += ikinciSayi;

            Console.WriteLine("Sonuc : " + sonuc);
        }
        static void soru2_AsalSayilar()
        {
            //1-100 arasındaki asal sayilari ekrana yazdıran program
            //en küçük asal sayi 2'dir.

            for (int i = 2; i <= 100; i++)
            {
                bool bolenVarmi = false;
                for (int j = 2; j < i / 2; j++)
                    if (i % j == 0)
                    {
                        bolenVarmi = true;
                        break;
                    }

                if (!bolenVarmi)
                    Console.WriteLine(i);
            }
        }
        static void soru3_RakamlarToplami()
        {
            // klavyden girilen 6 basamaklı sayının rakamları toplamı
            int sayi, toplam = 0;
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi > 0)
            {
                toplam += sayi % 10;
                sayi /= 10;
            }
            Console.WriteLine("Rakamlar toplamı:  {0}", toplam);

        }
        static void soru4_SinavSonucPuaniHesaplama()
        {
            int arasinav1, arasinav2, genelSinav;

            Console.WriteLine("1. arasinav notunu giriniz : ");
            arasinav1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. arasinav notunu giriniz : ");
            arasinav2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Genel sinav notunu giriniz : ");
            genelSinav = Convert.ToInt32(Console.ReadLine());

            var sonuc = (20 * arasinav1 / 100) + (30 * arasinav2 / 100) + (50 * genelSinav / 100);

            Console.WriteLine("Sonuç puani : " + sonuc);

        }
        static void soru5_SayiHanesi()
        {
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            string sayi = Console.ReadLine();

            int yuzlerBasamagi = Convert.ToInt32("" + sayi[1]);
            int birlerBasamagi = Convert.ToInt32("" + sayi[3]);

            int sonuc = (yuzlerBasamagi % 3) - birlerBasamagi;
            Console.WriteLine("Sonuc : " + sonuc);
        }
        static void soru6_BankadanParaCek()
        {
            Console.WriteLine("Cekmek isteyeceginiz para tutarini giriniz");
            int tutar = Convert.ToInt32(Console.ReadLine());

            var ikiyuzSayisi = tutar / 200;
            if (ikiyuzSayisi > 0)
                Console.WriteLine(ikiyuzSayisi + " tane 200tl");

            int kalanPara = tutar - ikiyuzSayisi * 200;

            if (kalanPara == 0)
                return;

            var yuzlukSayisi = kalanPara / 100;
            if (yuzlukSayisi > 0)
                Console.WriteLine(yuzlukSayisi + " tane 100tl");

            kalanPara -= yuzlukSayisi * 100;

            if (kalanPara == 0)
                return;

            var ellilikSayisi = kalanPara / 50;
            if (ellilikSayisi > 0)
                Console.WriteLine(ellilikSayisi + " tane 50tl");

            kalanPara -= ellilikSayisi * 50;

            if (kalanPara == 0)
                return;

            var yirmilikSayisi = kalanPara / 20;
            if (yirmilikSayisi > 0)
                Console.WriteLine(yirmilikSayisi + " tane 20tl");

            kalanPara -= yirmilikSayisi * 20;

            if (kalanPara == 0)
                return;

            var onlukSayisi = kalanPara / 10;
            if (onlukSayisi > 0)
                Console.WriteLine(onlukSayisi + " tane 10tl");

            kalanPara -= onlukSayisi * 10;

            if (kalanPara == 0)
                return;

            var beslikSayisi = kalanPara / 5;
            if (beslikSayisi > 0)
                Console.WriteLine(beslikSayisi + " tane 5tl");

            kalanPara -= beslikSayisi * 5;

            if (kalanPara == 0)
                return;
            else
                Console.WriteLine(kalanPara + "tl verilemedi!");

        }
    }
}
