using carparkclass;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace carparksystem
{
    public partial class Form5 : Form
    {
        private List<Arac> aracListesi = new List<Arac>();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            comboBox1.Items.Add("suv");
            comboBox1.Items.Add("binek araç");
            comboBox1.Items.Add("ticari araç");

         
            listBox1.Items.Add("suv");
            listBox1.Items.Add("ticari araç");
            listBox1.Items.Add("binek araç");
        }

     


        private Arac AracOlustur(string aracAdi)
        {
            switch (aracAdi)
            {
                case "suv":
                    return new SUV();
                case "binek araç":
                    return new BinekArac();
                case "ticari araç":
                    return new TicariArac();
                default:
                    throw new ArgumentException("Geçersiz araç adı");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

           
            string secilenArac = listBox1.SelectedItem.ToString();
            SUV s = new SUV();
            BinekArac b = new BinekArac();
            TicariArac t = new TicariArac();
            
            if (secilenArac== "suv")
            {
                
                label1.Text = $"{secilenArac} seçilmiştir.\n" + s.Calis();
            }

            if (secilenArac == "ticari araç")
            {

                label1.Text = $"{secilenArac} seçilmiştir.\n" + t.Calis();
            }

            if (secilenArac == "binek araç")
            {

                label1.Text = $"{secilenArac} seçilmiştir.\n" + b.Calis();
            }

            //Arac seciliArac = AracOlustur(secilenArac);

            //seciliArac.Calis();

            //label1.Text = $"{secilenArac} seçilmiştir.";


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Seçilen öğeyi al
            string secilenArac = comboBox1.SelectedItem.ToString();

            //Arac seciliArac = AracOlustur(secilenArac);

            //seciliArac.Calis();

            SUV s = new SUV();
            BinekArac b = new BinekArac();
            TicariArac t = new TicariArac();

            if (secilenArac == "suv")
            {

                label1.Text = $"{secilenArac} seçilmiştir.\n" + s.Calis();
            }

            if (secilenArac == "ticari araç")
            {

                label1.Text = $"{secilenArac} seçilmiştir.\n" + t.Calis();
            }

            if (secilenArac == "binek araç")
            {

                label1.Text = $"{secilenArac} seçilmiştir.\n" + b.Calis();
            }

            //abel1.Text = $"{secilenArac} seçilmiştir.";

        }
    }
}
