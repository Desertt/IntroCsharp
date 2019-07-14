using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama
{
    public class ClsHesaplama
    {
       
        
        public int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int[] topla(int v1, object sayi1, int v2, object sayi2)
        {
            throw new NotImplementedException();
        }

        public int bol(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

    }
}
