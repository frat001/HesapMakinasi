using System;
using System.Collections.Generic;
using System.Text;

namespace HesapMakinasi
{
    class MetinDüzenleyicileri
    {
        public static string Birleştir(string kelime1, string kelime2)
        {
            string sonuc = kelime1 + " " + kelime2;
            return sonuc;
        }

        public static string Buyutme(string kelime1)
        {
            
            string sonuc = kelime1.ToUpper();
            return sonuc;
        }    

        public static string Küçültme(string kelime1)
        {
            string sonuc = kelime1.ToLower();
            return sonuc;
        }

            


    }
}
