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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        List<carparkclass.kullanıcıyetki> list = new List<carparkclass.kullanıcıyetki>();
        private void button1_Click(object sender, EventArgs e)
        {
            IYetki z = new kullanıcıyetki();
            label1.Text = z.Belirlendi();
            carparkclass.kullanıcıyetki x = new carparkclass.kullanıcıyetki();
            if (radioButton1.Checked)
                x.AracUcret = x.BinekAracUcret;
            else if (radioButton2.Checked)
                x.AracUcret = x.SUVAracUcret;
            else if (radioButton3.Checked)
                x.AracUcret = x.TicariAracUcret;


            if (radioButton4.Checked)
                x.SaatUcret = x.BirİleBesSaat;
            else if (radioButton5.Checked)
                x.SaatUcret = x.BesİleOnSSaat;
            else if (radioButton6.Checked)
                x.SaatUcret = x.OnSaatuzeri;

            x.Otoparkucret = x.AracUcret * x.SaatUcret;

            if (checkBox1.Checked)
            {
                x.YeniUcret = x.Otoparkucret - x.OgrIndirim;
                label1.Text = "Öğrenci indirimli fiyat : " + x.YeniUcret;
            }
            else
                label1.Text = "Toplam Ücret : " + x.Otoparkucret + " TL'dir.";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            carparkclass.kullanıcıyetki x = new carparkclass.kullanıcıyetki();
            x.tc = int.Parse(textBox1.Text);
            if (checkBox1.Checked)
            {
                x.YeniUcret = x.Otoparkucret - x.OgrIndirim;

                label1.Text = "Öğrenci indirimli fiyat : " + x.YeniUcret;

                ////float yeniucret= x.Otoparkucret - x.OgrIndirim;
                //label3.Text = x.IndırımMesaj();

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
