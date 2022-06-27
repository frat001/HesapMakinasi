using System;
using System.Collections.Generic;
using System.Text;

namespace HesapMakinasi
{
    public class Hesaplamalar
    {
        public static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public static int Carpma(int sayi1, int sayi2)
        {

            int sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public static int Bolme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            return sonuc;
        }

        public static int Cıkarma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }



    }


}
