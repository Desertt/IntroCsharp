using System;
using IntroCsharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject1   //Burada Çoğu kütüphane gelmiyorkendimiz ekleyebiliriz (Örn.projede kullandığımız IntroCsharp )
{
    [TestClass]
    public class TestHesapla
    {
        public int sayi1,sayi2;

        [TestMethod]
        public void topla()  //Topla metodu
        {
            
            HesaplamaYap _hesap = new HesaplamaYap();  //IntroCsharp içerisinde ki HesaplamaYap Sınıfına değer göndermek için tanımlıyoruz
            int sonuc = _hesap.topla(20, 10); //sayi 1  ve sayi 2 değerleri

            //Beklenen Değer 30;

            Assert.AreEqual(30, sonuc); //ilk değer beklenen değer --İkinci değer ise sonuç değeri.Tamamı el ile girildi.
        }

        [TestMethod]
        public void cikar()
        {
            HesaplamaYap _hesap = new HesaplamaYap();
            int sonuc = _hesap.cikar(20, 10);

            //Beklenen Değer 10;

            Assert.AreEqual(10, sonuc);
        }

        [TestMethod]
        public void bol()
        {
            HesaplamaYap _hesap = new HesaplamaYap();
            int sonuc = _hesap.bol(20, 10);

            //Beklenen Değer 2;

            Assert.AreEqual(2, sonuc);
        }

        [TestMethod]
        public void carp()
        {
            HesaplamaYap _hesap = new HesaplamaYap();
            int sonuc = _hesap.carp(20, 10);

            //Beklenen Değer 200;

            Assert.AreEqual(200, sonuc);
        }


    }


}
