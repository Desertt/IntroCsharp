﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (comboBox1.Text=="Topla")
            {
                int sonuc = Convert.ToInt32(sayi1 + sayi2);
                labelSonuc.Text = sonuc.ToString();
            }
            
        }
    }
}
