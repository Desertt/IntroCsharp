using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCsharp
{
    public class HesaplamaYap
    {
        Form1 degerler = new Form1();
        
        
      
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
