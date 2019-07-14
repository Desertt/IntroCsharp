using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestHesapla
    {
        public int sayi1;
        public int sayi2;

        [TestMethod]
        public void topla()
        {
            Hesaplama.ClsHesaplama _hesap = new Hesaplama.ClsHesaplama();
            int[] sayilar = new int[2];
            sayilar[2] = _hesap.topla(sayi1, sayi2);
            int sonuc = _hesap.topla(sayilar[0], sayilar[1]);

            //Beklenen Değer 30;

            Assert.AreEqual(30, sonuc);
        }

        [TestMethod]
        public void cikar()
        {
            Hesaplama.ClsHesaplama _hesap = new Hesaplama.ClsHesaplama();
            int sonuc = _hesap.cikar(20, 10);

            //Beklenen Değer 10;

            Assert.AreEqual(10, sonuc);
        }

        [TestMethod]
        public void bol()
        {
            Hesaplama.ClsHesaplama _hesap = new Hesaplama.ClsHesaplama();
            int sonuc = _hesap.bol(20, 10);

            //Beklenen Değer 2;

            Assert.AreEqual(2, sonuc);
        }

        [TestMethod]
        public void carp()
        {
            Hesaplama.ClsHesaplama _hesap = new Hesaplama.ClsHesaplama();
            int sonuc = _hesap.carp(20, 10);

            //Beklenen Değer 200;

            Assert.AreEqual(200, sonuc);
        }


    }


}
