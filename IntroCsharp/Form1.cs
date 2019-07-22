using System;
using System.Windows.Forms;



namespace IntroCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butona basıldığında 
            //Merhaba mesajını göster
            /*
             * Bu da 
             * Açıklama
             * Satırı
             */
            MessageBox.Show("Merhaba");
        }

        public void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            HesaplamaYap h = new HesaplamaYap(); //dışarıda tanımladığımız HesaplamaYap Metodunu Burada Çağırdık-Girilen Değerleri Göndermek İçin
            CheckControl();
            if (checkedListBox1.SelectedIndex == 0)
            {
                labelSonuc.Text = h.topla(sayi1, sayi2).ToString();  ////girilen değerleri metod türüne göre sonuçlandırır

            }

            if (checkedListBox1.SelectedIndex == 1)
            {
                labelSonuc.Text = h.cikar(sayi1, sayi2).ToString();
            }

            if (checkedListBox1.SelectedIndex == 2)
            {
                labelSonuc.Text = h.carp(sayi1, sayi2).ToString();
            }

            if (checkedListBox1.SelectedIndex == 3)
            {
                labelSonuc.Text = h.bol(sayi1, sayi2).ToString();
            }

        }


        private void CheckControl()
        {
            for (int i = 0; i < checkedListBox1.SelectedItems.Count; i++)
            {
                if (i>0)
                {
                    MessageBox.Show("Birden Fazla İşlem Seçilemez !");
                }
                return;
            }

        }


        // TODO: Buraya da yapılacaklar listesini yazalım:

        /*SendTest metodu oluşturulacak ve bu metod ile form üzerinden girilen değerler TestHesapla Class'ına gönderilecektir.
         *Eşzamanlı test yapılması sağlanacaktır.Bileşenin test işlemleri otomatize edilmelidir.
         */


    }
}
