using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(sayi1 + "+" + sayi2 + " toplam sonucu: "+toplam); 
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
        }
    }
}
