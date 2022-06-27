using System;

namespace HesapMakinasi
{
    class Program
    {


        static void Main(string[] args)
        {
            AnaMenu();

            //HesapMakinesi();
            //MetinDüzenleyicisi();
        }




        public static void MetinDüzenleyicisi()
        {
            Console.WriteLine("Yazıyı Birleştirmek için 1 e Basın");
            Console.WriteLine("Yazıyı Büyütmek için 2 ye Basın");
            Console.WriteLine("Yazıyı Küçültmek için 3 e Basın");

            var yazıTipi = int.Parse(Console.ReadLine());

            string kelime1 = string.Empty;
            string kelime2 = string.Empty;
            string sonuc = string.Empty;

            if (yazıTipi == 1)
            {
                Console.WriteLine("1. Kelimeyi Girin");
                kelime1 = Console.ReadLine();
                Console.WriteLine("2. Kelimeyi Girin");
                kelime2 = Console.ReadLine();
                sonuc = MetinDüzenleyicileri.Birleştir(kelime1, kelime2);
            }
            else if (yazıTipi == 2)
            {
                Console.WriteLine(" Kelimeyi Girin");
                kelime1 = Console.ReadLine();
                sonuc = MetinDüzenleyicileri.Buyutme(kelime1,kelime2);

            }
            else if (yazıTipi == 3)
            {
                Console.WriteLine(" Kelimeyi Girin");
                kelime1 = Console.ReadLine();
                sonuc = MetinDüzenleyicileri.Küçültme(kelime1);

            }
            Console.WriteLine(sonuc);


            Console.WriteLine("Devam Etmek İstiyorsan E' ye Bas İstemiyorsan herhangi bir tuşa  Bas");
            Console.WriteLine("Ana Menüye Devam Etmek İstiyorsan 0 a bas");
            string devamMi = (Console.ReadLine()).ToUpper();
            if (devamMi == "E")
            {
                MetinDüzenleyicisi();
            }
            else if (devamMi == "0")
            {
                AnaMenu();
            }
        }
        public static void HesapMakinesi()
        {
            Console.WriteLine("Toplama Yapmak için 1 e basın");
            Console.WriteLine("Çıkarma Yapmak için 2 ye basın");
            Console.WriteLine("Çarpma Yapmak için 3 e basın");
            Console.WriteLine("Bölme Yapmak için 4 e basın");

            var hesapTipi = int.Parse(Console.ReadLine());

            int sayi2 = 0;
            int sayi1 = 0;
            var sonuc = 0;
            if (hesapTipi == 1)
            {
                Console.WriteLine("1. Sayıyı Girin");
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Girin");
                sayi2 = int.Parse(Console.ReadLine());

                sonuc = Hesaplamalar.Topla(sayi1, sayi2);
            }
            else if (hesapTipi == 2)
            {
                Console.WriteLine("1. Sayıyı Girin");
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Girin");
                sayi2 = int.Parse(Console.ReadLine());
                sonuc = Hesaplamalar.Cıkarma(sayi1, sayi2);
            }
            else if (hesapTipi == 3)
            {
                Console.WriteLine("1. Sayıyı Girin");
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Girin");
                sayi2 = int.Parse(Console.ReadLine());
                sonuc = Hesaplamalar.Carpma(sayi1, sayi2);
            }
            else if (hesapTipi == 4)
            {
                Console.WriteLine("1.Sayıyı Girin");
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Girin");
                sayi2 = int.Parse(Console.ReadLine());
                sonuc = Hesaplamalar.Bolme(sayi1, sayi2);
            }

            else
            {
                Console.WriteLine("Hatalı Seçim Tekrar Seçiniz");
                HesapMakinesi();
            }
            Console.WriteLine("Sonuç :" + sonuc);

            Console.WriteLine("Devam Etmek İstiyorsan E' ye Bas İstemiyorsan herhangi bir tuşa  Bas");
            Console.WriteLine("Ana Menüye Dönmek İstiyorsan 0 a Bas");
            string devamMi = Console.ReadLine();

            if (devamMi.ToUpper() == "E")
            {
                HesapMakinesi();
            }
            else if (int.Parse(devamMi) == 0)
            {
                AnaMenu();
            }
        }
        public static void AnaMenu()
        {
            Console.WriteLine("Hesap Makinesi için 1 e basın");
            Console.WriteLine("Metin Düzenleyicisi için 2 ye basın");

            var yapılacakİslem = int.Parse(Console.ReadLine());


            if (yapılacakİslem == 1)
            {
                HesapMakinesi();
            }
            else if (yapılacakİslem == 2)
            {
                MetinDüzenleyicisi();
            }
        }


    }
}
