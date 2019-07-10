using System;
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
    }
}
