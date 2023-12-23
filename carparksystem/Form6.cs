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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        { }

        kullanıcıyetki x = new kullanıcıyetki();
        
        private void button1_Click(object sender, EventArgs e)
        {
            IYetki seciliYetki = (IYetki)x;
            seciliYetki.Belirlendi();
            MessageBox.Show("Kullanıcı yetkisi girdileri belirlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seciliYetki.Guncelle();
            MessageBox.Show("Yetkili yetkisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        yetkiliyetki y = new yetkiliyetki(12, 12, 12);
        private void button2_Click(object sender, EventArgs e)
        {
            IYetki seciliYetki = (IYetki)y;
            seciliYetki.Belirlendi();
            MessageBox.Show("Yetkili yetkisi girdileri belirlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seciliYetki.Guncelle();
            MessageBox.Show("Yetkili yetkisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

