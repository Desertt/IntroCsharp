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
            h.topla(sayi1, sayi2);

            if (comboBox1.Text == "Topla")
            {
                int sonuc = Convert.ToInt32(sayi1 + sayi2);
                labelSonuc.Text = sonuc.ToString();
            }

            h.cikar(sayi1, sayi2);
            if (comboBox1.Text == "Çıkar")
            {
                int sonuc = Convert.ToInt32(sayi1 + sayi2);
                labelSonuc.Text = sonuc.ToString();
            }

            h.bol(sayi1, sayi2);
            if (comboBox1.Text == "Böl")
            {
                int sonuc = Convert.ToInt32(sayi1 + sayi2);
                labelSonuc.Text = sonuc.ToString();
            }

            h.carp(sayi1, sayi2);
            if (comboBox1.Text == "Çarp")
            {
                int sonuc = Convert.ToInt32(sayi1 + sayi2);
                labelSonuc.Text = sonuc.ToString();
            }

        }

    }
}
