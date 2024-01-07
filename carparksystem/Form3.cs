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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Salı");
            comboBox1.Items.Add("Çarşamba");
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");
            comboBox1.Items.Add("Cumartesi");
            comboBox1.Items.Add("Pazar");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carparkclass.adminyetki x = new carparkclass.adminyetki(float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox3.Text));
            IYetki y = new yetki();
            label4.Text = x.MesajYazdir() + "\n" + y.Belirlendi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            carparkclass.adminyetki x = new carparkclass.adminyetki(float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox3.Text));

            if (comboBox1.SelectedIndex == 0)
                label6.Text = x.Pazartesi();
            else if (comboBox1.SelectedIndex == 1)
                label6.Text = x.Sali();
            else if (comboBox1.SelectedIndex == 2)
                label6.Text = x.Carsamba();
            else if (comboBox1.SelectedIndex == 3)
                label6.Text = x.Persembe();
            else if (comboBox1.SelectedIndex == 4)
                label6.Text = x.Cuma();
            else if (comboBox1.SelectedIndex == 5)
                label6.Text = x.Cumartesi();
            else if (comboBox1.SelectedIndex == 6)
                label6.Text = x.Pazar();
        }
    }
}
