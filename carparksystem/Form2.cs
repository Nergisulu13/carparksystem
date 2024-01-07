using carparkclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace carparksystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carparkclass.yetkiliyetki x = new carparkclass.yetkiliyetki(float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox3.Text));
            label4.Text = x.MesajYazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carparkclass.yetkiliyetki x = new carparkclass.yetkiliyetki(float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox3.Text));
            x.BosParkalani = int.Parse(textBox4.Text);
            x.BinekAracSayisi = int.Parse(textBox5.Text);
            x.SuvAracSayisi = int.Parse(textBox6.Text);
            x.TicariAracSayisi = int.Parse(textBox7.Text);
            x.ToplamAracSayisi = x.BinekAracSayisi + x.SuvAracSayisi + x.TicariAracSayisi;


            label10.Text = "Boş park alanı sayısı : " + x.BosParkalani +
                          "\nOtoparkta bulunan toplam araç sayısı : " + x.ToplamAracSayisi;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
